using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsMediaPlayer.Mediahelpers;

namespace WindowsFormsMediaPlayer
{
    public class MediaTrack
    {
        private string _pathToFile = String.Empty;
        public string MediaPath
        {
            get { return _pathToFile; }
            set
            {
                if (MediaFilter.IsMediaFile(Path.GetExtension(value)))
                {
                    _pathToFile = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect media format");
                }
            }
        }
    }
}
