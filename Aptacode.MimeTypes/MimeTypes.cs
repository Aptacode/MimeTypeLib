using System;
using System.Collections.Generic;
using System.Linq;

namespace Aptacode.MimeTypes
{
    public static partial class MimeTypes
    {
        //Dictionary containing each MimeType and their compatible extensions
        private static readonly Dictionary<MimeType, HashSet<string>> ExtensionDictionary =
            new Dictionary<MimeType, HashSet<string>>
            {
                //Na
                {MimeType.None, new HashSet<string>()},

                //Application
                {Application.Pdf, new HashSet<string> {".pdf"}},
                {Application.Json, new HashSet<string> {".json"}},

                //Text
                {Text.Html, new HashSet<string> {".html"}},
                {Text.Richtext, new HashSet<string> {".rtf"}},
                {Text.Plain, new HashSet<string> {".txt"}},

                //Image 
                {Image.Apng, new HashSet<string> {".apng"}},
                {Image.Bmp, new HashSet<string> {".bmp"}},
                {Image.Gif, new HashSet<string> {".gif"}},
                {Image.Ico, new HashSet<string> {".ico", ".cur"}},
                {Image.Jpeg, new HashSet<string> {".jpg", ".jpeg", ".jfif", ".pjpeg", ".pjp"}},
                {Image.Png, new HashSet<string> {".png"}},
                {Image.Svg, new HashSet<string> {".svg"}},
                {Image.Tiff, new HashSet<string> {".tif", ".tiff"}},
                {Image.WebP, new HashSet<string> {".webp"}},

                //Audio
                {Audio.Wav, new HashSet<string>()},
                {Audio.Wave, new HashSet<string>()},

                //Video
                {Video.Webm, new HashSet<string>()}
            };

        public static IEnumerable<MimeType> All()
        {
            return ExtensionDictionary.Keys.Distinct();
        }

        public static IEnumerable<MimeType> Get(string extension)
        {
            return ExtensionDictionary.Where(pair => pair.Value.Contains(extension)).Select(pair => pair.Key);
        }

        public static void Add(MimeType mimeType, params string[] extensions)
        {
            if (!ExtensionDictionary.TryGetValue(mimeType, out var extensionSet))
            {
                extensionSet = new HashSet<string>();
                ExtensionDictionary.Add(mimeType, extensionSet);
            }

            foreach (var extension in extensions)
            {
                extensionSet.Add(extension);
            }
        }

        internal static IEnumerable<MimeType> GetMimeTypeProperties(Type type)
        {
            return type.GetProperties().Select(p => p.GetValue(null, null) as MimeType).Where(p => p != null);
        }

        #region Extensions

        public static class Extensions
        {
            public static IEnumerable<string> All()
            {
                return ExtensionDictionary.Values.Select(hs => hs.ToList()).Aggregate((a, b) => a.Concat(b).ToList())
                    .Distinct();
            }

            public static IEnumerable<string> All(MimeType mimeType)
            {
                return ExtensionDictionary.TryGetValue(mimeType, out var extensionSet)
                    ? extensionSet.ToList()
                    : new List<string>();
            }
        }

        #endregion
    }
}