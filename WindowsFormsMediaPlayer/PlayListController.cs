using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormsMediaPlayer
{
    public class PlayListController : IEnumerable
    {
        private string _playlistsFilePath = "playLists.xml";

        private List<MediaPlayList> _mediaPlayLists;
        public PlayListController()
        {
            LoadPlayLists();
        }
        public IEnumerator GetEnumerator()
        {
            return _mediaPlayLists.GetEnumerator();
        }
        public MediaPlayList this[string name]
        {
            get
            {
                foreach (var item in _mediaPlayLists)
                {
                    if (item.Name == name)
                    {
                        return item;
                    }
                }
                return null;
            }
        }
        public void CreatePlayList(string name)
        {
            _mediaPlayLists.Add(new MediaPlayList(name));
            SavePlayLists();
        }
        public void DeletePlayList(string name)
        {
            _mediaPlayLists.Remove(this[name]);
            SavePlayLists();
        }
        public void RenamePlayList(string oldName, string newName)
        {
            this[oldName].Name = newName;
            SavePlayLists();
        }
        public void AddMediaTrack(string name, MediaTrack mediaTrack)
        {
            this[name].AddTrack(mediaTrack);
            SavePlayLists();
        }
        public void RemoveMediaTrack(string name, MediaTrack mediaTrack)
        {
            this[name].RemoveTrack(mediaTrack);
            SavePlayLists();
        }
        private void LoadPlayLists()
        {
            if (!File.Exists(_playlistsFilePath))
            {
                SavePlayLists();
                return;
            }
            XmlSerializer serializer = new XmlSerializer(typeof(List<MediaPlayList>));
            using (StreamReader reader = new StreamReader(_playlistsFilePath))
            {
                _mediaPlayLists = (List<MediaPlayList>)serializer.Deserialize(reader);
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
