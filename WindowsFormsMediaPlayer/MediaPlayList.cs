using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMediaPlayer
{
    public class MediaPlayList
    {
        public string Name { get; set; }

        private List<MediaTrack> _mediaTracks;

        public MediaPlayList()
        {
            _mediaTracks = new List<MediaTrack>();
        }

        public MediaPlayList(string name)
        {
            _mediaTracks = new List<MediaTrack>();
            Name = name;
        }

        public void AddTrack(MediaTrack track)
        {
            _mediaTracks.Add(track);
        }
        public void AddTrackRange(IEnumerable<MediaTrack> tracks)
        {
            _mediaTracks.AddRange(tracks);
        }
        public void RemoveTrack(MediaTrack track)
        {
            _mediaTracks.Remove(track);
        }
    }
}
