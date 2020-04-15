using System.Collections.Generic;

namespace Aptacode.MimeTypes
{
    public static partial class MimeTypes
    {
        public static class Audio
        {
            public const string Type = nameof(Audio);
            public static MimeType Wave { get; } = new MimeType(Type, nameof(Wave));
            public static MimeType Wav { get; } = new MimeType(Type, nameof(Wav));

            public static IEnumerable<MimeType> All()
            {
                return GetMimeTypeProperties(typeof(Audio));
            }
        }
    }
}