using System.Collections.Generic;

namespace Aptacode.MimeTypes
{
    public static partial class MimeTypes
    {
        public static class Video
        {
            public const string Type = nameof(Video);
            public static MimeType Webm { get; } = new MimeType(Type, nameof(Webm));

            public static IEnumerable<MimeType> All()
            {
                return GetMimeTypeProperties(typeof(Video));
            }
        }
    }
}