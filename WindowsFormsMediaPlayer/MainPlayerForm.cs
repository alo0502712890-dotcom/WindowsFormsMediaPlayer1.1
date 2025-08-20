using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using LibVLCSharp.Shared;
using WindowsFormsMediaPlayer.Mediahelpers;

namespace WindowsFormsMediaPlayer
{
    public partial class MainPlayerForm : Form
    {
        private LibVLC _libVLC;
        private MediaPlayer _mediaPlayer;
        private PlayListController _playListController;
        private PlayListsForm _playListsForm;

        private const int DefaultVolume = 50;
        private int _lastNonZeroVolume = DefaultVolume;
        private bool _isMuted = false;
        private Image _iconOn;
        private Image _iconMute;

        private readonly List<MediaTrack> _currentQueue = new List<MediaTrack>();
        private int _currentIndex = -1;
        private MediaPlayList _queuePlaylistRef;


        public MainPlayerForm()
        {
            InitializeComponent();
            Core.Initialize(); 

            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);
            videoView_Player.MediaPlayer = _mediaPlayer;

            _playListController = new PlayListController();

            
            try
            {
                _iconOn = Properties.Resources.soundon1;
                _iconMute = Properties.Resources.soundoff1;
            }
            catch
            {
                _iconOn = null;
                _iconMute = null;
            }

            button_SoundMute.Image = null;
            button_SoundMute.BackgroundImage = _iconOn;
            button_SoundMute.BackgroundImageLayout = ImageLayout.Zoom;
            button_SoundMute.Text = string.Empty;
            button_SoundMute.FlatStyle = FlatStyle.Flat;
            button_SoundMute.FlatAppearance.BorderSize = 0;
            button_SoundMute.Dock = DockStyle.None;

            _mediaPlayer.Mute = false;
            _mediaPlayer.Volume = DefaultVolume;
            trackBar_Sound.Value = DefaultVolume;

            button_SoundMute.Click -= button_SoundMute_Click;
            button_SoundMute.Click += button_SoundMute_Click;
            trackBar_Sound.Scroll -= trackBar_Sound_Scroll;
            trackBar_Sound.Scroll += trackBar_Sound_Scroll;


            button_PauseStop.Click -= button_PauseStop_Click;
            button_PauseStop.Click += button_PauseStop_Click;

            button_Next.Click -= button_Next_Click;
            button_Next.Click += button_Next_Click;

            button_Prev.Click -= button_Prev_Click;
            button_Prev.Click += button_Prev_Click;

            button1.Click -= button1_Click;
            button1.Click += button1_Click;


            _mediaPlayer.EndReached += (s, e) =>
            {
              
                if (!IsDisposed) BeginInvoke(new Action(PlayNext));
            };


            UpdateMuteIcon();
        }

        public void PlayMedia(string path)
        {
            if (File.Exists(path))
            {
                _mediaPlayer.Media?.Dispose();
                _mediaPlayer.Media = new Media(_libVLC, new Uri(path));
                _mediaPlayer.Play();
                toolStripStatusLabel_Info.Text = Path.GetFileName(path);
            }
            else
            {
                MessageBox.Show("Файл не найден: " + path, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = MediaFilter.GetOpenMediFilter();
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                PlayMedia(dlg.FileName);
            }
        }

        private void trackBar_Sound_Scroll(object sender, EventArgs e)
        {
            int v = Math.Max(0, Math.Min(100, trackBar_Sound.Value));
            _mediaPlayer.Volume = v;
            if (v > 0)
            {
                _lastNonZeroVolume = v; 
                _isMuted = false;
            }
            else
            {
                _isMuted = true;
            }

            _mediaPlayer.Mute = _isMuted;
            UpdateMuteIcon();
        }

        private void button_SoundMute_Click(object sender, EventArgs e)
        {
            if (!_isMuted && _mediaPlayer.Volume > 0)
            {
                _lastNonZeroVolume = _mediaPlayer.Volume;
            }

            _isMuted = !_isMuted;
            _mediaPlayer.Mute = _isMuted;

            if (_isMuted)
            {
                _mediaPlayer.Volume = 0;
                trackBar_Sound.Value = 0;              
            }
            else
            {
                int restore = _lastNonZeroVolume > 0 ? _lastNonZeroVolume : DefaultVolume;
                _mediaPlayer.Volume = restore;
                trackBar_Sound.Value = restore;        
            }

            UpdateMuteIcon();
        }

        private void UpdateMuteIcon()
        {
            button_SoundMute.BackgroundImage = _isMuted ? _iconMute : _iconOn;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            try
            {
                _mediaPlayer?.Dispose();
                _libVLC?.Dispose();
            }
            finally
            {
                base.OnFormClosed(e);
            }
        }

        private void playlistsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_playListsForm == null || _playListsForm.IsDisposed)
            {
                _playListsForm = new PlayListsForm(this, _playListController);
            }
            _playListsForm.Location = new Point(this.Location.X + this.Size.Width, this.Location.Y);
            _playListsForm.Show();
            _playListsForm.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlayCurrent();
        }

        private void button_Prev_Click(object sender, EventArgs e)
        {
            PlayPrev();
        }

        private void button_PauseStop_Click(object sender, EventArgs e)
        {
            TogglePause();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            PlayNext();
        }

        public void SetQueue(MediaPlayList playlist, IEnumerable<MediaTrack> tracks, int startIndex = 0)
        {
            _queuePlaylistRef = playlist;                
            _currentQueue.Clear();
            if (tracks != null) _currentQueue.AddRange(tracks.Where(t => t != null));

            if (_currentQueue.Count == 0)
            {
                _currentIndex = -1;
                return;
            }

            _currentIndex = Math.Max(0, Math.Min(startIndex, _currentQueue.Count - 1));
            PlayIndex(_currentIndex);
        }


        private void PlayIndex(int index)
        {
            if (index < 0 || index >= _currentQueue.Count) return;

            var track = _currentQueue[index];
            if (track == null || string.IsNullOrWhiteSpace(track.MediaPath) || !File.Exists(track.MediaPath))
            {
                PlayNext();
                return;
            }

            _currentIndex = index;
            PlayMedia(track.MediaPath);


            _playListsForm?.SelectPlaylistAndIndex(_queuePlaylistRef, _currentIndex);
        }


        public void PlayCurrent()
        {
            if (_currentIndex < 0 && _currentQueue.Count > 0)
                _currentIndex = 0;

            if (_currentIndex >= 0)
                PlayIndex(_currentIndex);
        }

        public void PlayNext()
        {
            if (_currentQueue.Count == 0) return;
            int next = (_currentIndex + 1) % _currentQueue.Count;
            PlayIndex(next);
        }

        public void PlayPrev()
        {
            if (_currentQueue.Count == 0) return;
            int prev = (_currentIndex - 1 + _currentQueue.Count) % _currentQueue.Count;
            PlayIndex(prev);
        }

        public void TogglePause()
        {
            if (_mediaPlayer == null) return;

            if (_mediaPlayer.IsPlaying)
            {
                _mediaPlayer.SetPause(true);
            }
            else
            {
                _mediaPlayer.SetPause(false);
                if (_mediaPlayer.Media == null)
                {

                    PlayCurrent();
                }
                else
                {
                    _mediaPlayer.Play();
                }
            }
        }

    }
}