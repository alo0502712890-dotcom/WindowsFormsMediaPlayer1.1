using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsMediaPlayer.Mediahelpers;

namespace WindowsFormsMediaPlayer
{
    public partial class PlayListsForm : Form
    {
        private readonly MainPlayerForm _parentPlayerForm;
        private readonly PlayListController _playListController;

        public PlayListsForm(MainPlayerForm parent, PlayListController controller)
        {
            InitializeComponent();
            _parentPlayerForm = parent;
            _playListController = controller;

            // ← ЖЁСТКАЯ ПОДПИСКА НА СОБЫТИЯ (если дизайнер не привязал)
            button_AddOneMediaRecord.Click += button_AddOneMediaRecord_Click;
            button_AddManyRecord.Click += button_AddManyRecord_Click;
            button_DeleteOneRecord.Click += button_DeleteOneRecord_Click;
            listBox_MediaRecords.DoubleClick += listBox_MediaRecords_DoubleClick;
            this.FormClosing += PlayListsForm_FormClosing;
            toolStripComboBox_PlayLists.SelectedIndexChanged += toolStripComboBox_PlayLists_SelectedIndexChanged;

            // Если в хранилище нет ни одного плейлиста — создадим "Default"
            if (_playListController.All == null || _playListController.All.Count == 0)
            {
                _playListController.AddPlayList("Default");
            }

            listBox_MediaRecords.SelectedIndexChanged += (s, e) =>
            {
                button_DeleteOneRecord.Enabled =
                    CurrentPlaylist != null && listBox_MediaRecords.SelectedItem is MediaTrack;
            };

            LoadPlaylistsToUi();
        }

        private void LoadPlaylistsToUi()
        {
            toolStripComboBox_PlayLists.Items.Clear();
            foreach (var pl in _playListController.All)
            {
                toolStripComboBox_PlayLists.Items.Add(pl);
            }
            if (toolStripComboBox_PlayLists.Items.Count > 0)
                toolStripComboBox_PlayLists.SelectedIndex = 0;

            RefreshTracksList();
        }

        private MediaPlayList CurrentPlaylist =>
            toolStripComboBox_PlayLists.SelectedItem as MediaPlayList;

        private void RefreshTracksList()
        {
            listBox_MediaRecords.Items.Clear();
            bool hasPl = CurrentPlaylist != null;
            button_AddOneMediaRecord.Enabled = hasPl;
            button_AddManyRecord.Enabled = hasPl;
            button_DeleteOneRecord.Enabled = hasPl && listBox_MediaRecords.SelectedItem != null;

            if (!hasPl) return;
            foreach (var t in CurrentPlaylist.Tracks)
                listBox_MediaRecords.Items.Add(t);
        }

        private void toolStripButton_Add_Click(object sender, EventArgs e)
        {
            using (var dlg = new CreateUodatePlayListForm())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _playListController.AddPlayList(dlg.PlayListName);
                    LoadPlaylistsToUi();
                    toolStripComboBox_PlayLists.SelectedItem =
                        _playListController[dlg.PlayListName];
                }
            }
        }

        private void toolStripButton_Edit_Click(object sender, EventArgs e)
        {
            if (CurrentPlaylist == null) return;
            using (var dlg = new CreateUodatePlayListForm(CurrentPlaylist.Name))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _playListController.RenamePlayList(CurrentPlaylist.Name, dlg.PlayListName);
                    LoadPlaylistsToUi();
                    toolStripComboBox_PlayLists.SelectedItem =
                        _playListController[dlg.PlayListName];
                }
            }
        }

        private void toolStripButton_Delete_Click(object sender, EventArgs e)
        {
            if (CurrentPlaylist == null) return;
            if (MessageBox.Show($"Удалить плейлист \"{CurrentPlaylist.Name}\"?",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _playListController.DeletePlayList(CurrentPlaylist.Name);
                LoadPlaylistsToUi();
            }
        }

        private void toolStripComboBox_PlayLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTracksList();
        }

        private void button_AddOneMediaRecord_Click(object sender, EventArgs e)
        {
            if (CurrentPlaylist == null) return;

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = MediaFilter.GetOpenMediFilter();
            dlg.Multiselect = false;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var track = new MediaTrack { MediaPath = dlg.FileName };
                _playListController.AddMediaTrack(CurrentPlaylist.Name, track);
                RefreshTracksList();
            }
        }

        private void button_AddManyRecord_Click(object sender, EventArgs e)
        {
            if (CurrentPlaylist == null) return;

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = MediaFilter.GetOpenMediFilter();
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                foreach (var f in dlg.FileNames)
                {
                    var track = new MediaTrack { MediaPath = f };
                    _playListController.AddMediaTrack(CurrentPlaylist.Name, track);
                }
                RefreshTracksList();
            }
        }

        private void button_DeleteOneRecord_Click(object sender, EventArgs e)
        {
            if (CurrentPlaylist == null) return;
            if (listBox_MediaRecords.SelectedItem is MediaTrack track)
            {
                _playListController.RemoveMediaTrack(CurrentPlaylist.Name, track);
                RefreshTracksList();
            }
        }

        private void listBox_MediaRecords_DoubleClick(object sender, EventArgs e)
        {
            if (CurrentPlaylist == null) return;
            if (listBox_MediaRecords.SelectedIndex < 0) return;

            _parentPlayerForm.SetQueue(CurrentPlaylist, CurrentPlaylist.Tracks, listBox_MediaRecords.SelectedIndex);
        }


        private void PlayListsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }


        public void SelectPlaylistAndIndex(MediaPlayList playlist, int index)
        {
            if (playlist == null) return;

            int target = -1;
            for (int i = 0; i < toolStripComboBox_PlayLists.Items.Count; i++)
            {
                var pl = (MediaPlayList)toolStripComboBox_PlayLists.Items[i];
                if (object.ReferenceEquals(pl, playlist) ||
                    string.Equals(pl.Name, playlist.Name, StringComparison.OrdinalIgnoreCase))
                {
                    target = i;
                    break;
                }
            }
            if (target >= 0 && toolStripComboBox_PlayLists.SelectedIndex != target)
            {
                toolStripComboBox_PlayLists.SelectedIndex = target;

            }
            else
            {
                RefreshTracksList();
            }

            if (index >= 0 && index < listBox_MediaRecords.Items.Count)
            {
                listBox_MediaRecords.SelectedIndex = index;
                listBox_MediaRecords.TopIndex = Math.Max(0, index - 3); 
            }
        }

    }
}