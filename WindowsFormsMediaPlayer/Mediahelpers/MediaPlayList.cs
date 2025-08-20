using System;
using System.Collections.Generic;

namespace WindowsFormsMediaPlayer
{
    public class MediaPlayList
    {
        public string Name { get; set; }

        private readonly List<MediaTrack> _mediaTracks = new List<MediaTrack>();
        public IReadOnlyList<MediaTrack> Tracks => _mediaTracks.AsReadOnly();

        public MediaPlayList() { }

        public MediaPlayList(string name)
        {
            Name = name;
        }

        public void AddTrack(MediaTrack track)
        {
            if (track == null) return;
            _mediaTracks.Add(track);
        }

        public void AddTracks(IEnumerable<MediaTrack> tracks)
        {
            if (tracks == null) return;
            _mediaTracks.AddRange(tracks);
        }

        public void RemoveTrack(MediaTrack track)
        {
            if (track == null) return;
            _mediaTracks.Remove(track);
        }

        public override string ToString() => Name;
    }
}