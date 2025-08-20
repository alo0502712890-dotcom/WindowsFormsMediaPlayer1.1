using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace WindowsFormsMediaPlayer
{
    public class PlayListController : IEnumerable
    {
        private readonly string _playlistsFilePath = "playLists.xml";
        private List<MediaPlayList> _mediaPlayLists = new List<MediaPlayList>();

        public PlayListController()
        {
            LoadPlayLists();
        }

        public IEnumerator GetEnumerator() => _mediaPlayLists.GetEnumerator();

        public MediaPlayList this[string name]
        {
            get => _mediaPlayLists.FirstOrDefault(p => string.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase));
        }

        public IReadOnlyList<MediaPlayList> All => _mediaPlayLists.AsReadOnly();

        public void AddPlayList(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return;
            if (_mediaPlayLists.Any(p => string.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase))) return;
            _mediaPlayLists.Add(new MediaPlayList(name));
            SavePlayLists();
        }

        public void DeletePlayList(string name)
        {
            var pl = this[name];
            if (pl == null) return;
            _mediaPlayLists.Remove(pl);
            SavePlayLists();
        }

        public void RenamePlayList(string oldName, string newName)
        {
            var pl = this[oldName];
            if (pl == null || string.IsNullOrWhiteSpace(newName)) return;
            if (_mediaPlayLists.Any(p => string.Equals(p.Name, newName, StringComparison.OrdinalIgnoreCase))) return;
            pl.Name = newName;
            SavePlayLists();
        }

        public void AddMediaTrack(string name, MediaTrack mediaTrack)
        {
            var pl = this[name];
            if (pl == null) return;
            pl.AddTrack(mediaTrack);
            SavePlayLists();
        }

        public void RemoveMediaTrack(string name, MediaTrack mediaTrack)
        {
            var pl = this[name];
            if (pl == null) return;
            pl.RemoveTrack(mediaTrack);
            SavePlayLists();
        }

        private void LoadPlayLists()
        {
            if (!File.Exists(_playlistsFilePath))
            {
                _mediaPlayLists = new List<MediaPlayList>();
                SavePlayLists();
                return;
            }
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<MediaPlayList>));
                using (StreamReader reader = new StreamReader(_playlistsFilePath))
                {
                    _mediaPlayLists = (List<MediaPlayList>)serializer.Deserialize(reader);
                }
            }
            catch
            {
                _mediaPlayLists = new List<MediaPlayList>();
            }
        }

        private void SavePlayLists()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<MediaPlayList>));
            using (StreamWriter writer = new StreamWriter(_playlistsFilePath))
            {
                serializer.Serialize(writer, _mediaPlayLists);
            }
        }
    }
}