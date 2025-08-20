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

            string vids = string.Join(";", videoExtensions.Select(e => "*" + e));
            string auds = string.Join(";", audioExtensions.Select(e => "*" + e));
            string all = string.Join(";", videoExtensions.Concat(audioExtensions).Select(e => "*" + e));


            return $"Media files|{all}|Audio|{auds}|Video|{vids}|All files|*.*";
        }

        public static bool IsMediaFile(string extension)
        {
            if (string.IsNullOrWhiteSpace(extension)) return false;

            string ext = extension.StartsWith(".")
                ? extension.ToLowerInvariant()
                : ("." + extension.ToLowerInvariant());

            return videoExtensions.Contains(ext) || audioExtensions.Contains(ext);
        }
    }
}
