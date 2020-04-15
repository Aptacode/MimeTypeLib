using System.Collections.Generic;

namespace Aptacode.MimeTypes
{
    public static partial class MimeTypes
    {
        public static class Image
        {
            public const string Type = nameof(Image);
            public static MimeType Apng { get; } = new MimeType(Type, nameof(Apng));
            public static MimeType Bmp { get; } = new MimeType(Type, nameof(Bmp));
            public static MimeType Gif { get; } = new MimeType(Type, nameof(Gif));
            public static MimeType Ico { get; } = new MimeType(Type, nameof(Ico));
            public static MimeType Jpeg { get; } = new MimeType(Type, nameof(Jpeg));
            public static MimeType Png { get; } = new MimeType(Type, nameof(Png));
            public static MimeType Svg { get; } = new MimeType(Type, nameof(Svg));
            public static MimeType Tiff { get; } = new MimeType(Type, nameof(Tiff));
            public static MimeType WebP { get; } = new MimeType(Type, nameof(WebP));

            public static IEnumerable<MimeType> All()
            {
                return GetMimeTypeProperties(typeof(Image));
            }
        }
    }
}