using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsMediaPlayer.Mediahelpers
{
    public class MediaFilter
    {
        private static string[] videoExtensions = new string[]
        {
            ".mp4", ".avi", ".mkv", ".mov", ".wmv", ".flv", ".webm", ".mpeg", ".mpg", ".3gp"
        };

        private static string[] audioExtensions = new string[]
        {
             ".mp3", ".wav", ".flac", ".aac", ".ogg", ".wma", ".m4a", ".aiff", ".alac", ".opus"
        };
        private static string FormatFilter(string label, string[] extensions)
        {
            string formatted = string.Join(";", extensions.Select(ext => "*" + ext));
            return $"{label}|{formatted}";
        }

        public static string GetOpenMediFilter()
        {
            string filter = string.Join("|", new string[]
            {
                FormatFilter("Video", videoExtensions),
                FormatFilter("Аудио", audioExtensions),
                FormatFilter("Все файлы", new string[] { ".*" })
            });
            return filter;
        }
    }
}
