using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsMediaPlayer.Mediahelpers;

namespace WindowsFormsMediaPlayer
{
    public partial class MainPlayerForm : Form
    {
        private LibVLC _libVLC;
        private MediaPlayer _mediaPlayer;

        private PlayListController _playListController;

        private PlayListsForm _playlistsForm;

        private const int DefaultVolume = 50;
        private int _lastNonZeroVolume = DefaultVolume;

        private Image _iconOn = Properties.Resources.soundon1;
        private Image _iconOff = Properties.Resources.soundoff1;

        public MainPlayerForm()
        {
            InitializeComponent();

            Core.Initialize();
            _libVLC = new LibVLC();
            _mediaPlayer = new MediaPlayer(_libVLC);
            videoView_Player.MediaPlayer = _mediaPlayer;

            _playListController = new PlayListController();

            button_SoundMute.Image = null;                      
            button_SoundMute.BackgroundImage = _iconOn;          
            button_SoundMute.BackgroundImageLayout = ImageLayout.Zoom;
            button_SoundMute.Text = string.Empty;
            button_SoundMute.FlatStyle = FlatStyle.Flat;
            button_SoundMute.FlatAppearance.BorderSize = 0;

            button_SoundMute.Dock = DockStyle.None;
            button_SoundMute.Size = new Size(55, 55);
            button_SoundMute.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button_SoundMute.BringToFront();

            trackBar_Sound.Minimum = 0;
            trackBar_Sound.Maximum = 100;
            trackBar_Sound.TickFrequency = 10;
            trackBar_Sound.Value = DefaultVolume;

            _mediaPlayer.Mute = false;
            _mediaPlayer.Volume = DefaultVolume;


            button_SoundMute.Click -= button_SoundMute_Click;
            button_SoundMute.Click += button_SoundMute_Click;
            trackBar_Sound.Scroll -= trackBar_Sound_Scroll;
            trackBar_Sound.Scroll += trackBar_Sound_Scroll;

            UpdateMuteIcon();
        }


        private void button_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = MediaFilter.GetOpenMediFilter();
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _mediaPlayer.Media = new Media(_libVLC, new Uri(dlg.FileName));
                _mediaPlayer.Play();
            }
        }

        private void trackBar_Sound_Scroll(object sender, EventArgs e)
        {
            int v = Math.Max(0, Math.Min(100, trackBar_Sound.Value));
            _mediaPlayer.Volume = v;

            if (v == 0)
            {
                _mediaPlayer.Mute = true;
            }
            else
            {
                _mediaPlayer.Mute = false;
                _lastNonZeroVolume = v;
            }

            UpdateMuteIcon();
        }

        private void button_SoundMute_Click(object sender, EventArgs e)
        {
            bool isMuted = _mediaPlayer.Mute || _mediaPlayer.Volume == 0;

            if (!isMuted)
            {
                _mediaPlayer.Mute = true;
                _mediaPlayer.Volume = 0;
                trackBar_Sound.Value = 0;
            }
            else
            {
                int restore = _lastNonZeroVolume > 0 ? _lastNonZeroVolume : DefaultVolume;
                _mediaPlayer.Mute = false;
                _mediaPlayer.Volume = restore;
                trackBar_Sound.Value = restore;
            }

            UpdateMuteIcon();
        }

        private void UpdateMuteIcon()
        {
            bool muted = _mediaPlayer.Mute || _mediaPlayer.Volume <= 0;
            button_SoundMute.BackgroundImage = muted ? _iconOff : _iconOn;
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
        private void ShowPlaylists()
        {
            if (_playlistsForm == null || _playlistsForm.IsDisposed)
            {
                _playlistsForm = new PlayListsForm();
              
                _playlistsForm.StartPosition = FormStartPosition.Manual;
                _playlistsForm.Location = new Point(this.Right + 5, this.Top);

                _playlistsForm.FormClosing += (s, e) =>
                {
                    if (e.CloseReason == CloseReason.UserClosing)
                    {
                        e.Cancel = true;    
                        _playlistsForm.Hide(); 
                    }
                };
            }

            if (!_playlistsForm.Visible)
                _playlistsForm.Show(this);   // немодально
            else
                _playlistsForm.BringToFront();
        }

        private void TogglePlaylists()
        {
            if (_playlistsForm == null || _playlistsForm.IsDisposed)
            {
                ShowPlaylists();
                return;
            }

            if (_playlistsForm.Visible)
                _playlistsForm.Hide();
            else
                _playlistsForm.Show(this);
        }


        private void playlistsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TogglePlaylists();
        }
    }
}
