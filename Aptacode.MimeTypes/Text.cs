using System.Collections.Generic;

namespace Aptacode.MimeTypes
{
    public static partial class MimeTypes
    {
        public static class Text
        {
            public const string Type = nameof(Text);
            public static MimeType Html { get; } = new MimeType(Type, nameof(Html));
            public static MimeType Plain { get; } = new MimeType(Type, nameof(Plain));
            public static MimeType Richtext { get; } = new MimeType(Type, nameof(Richtext));

            public static IEnumerable<MimeType> All()
            {
                return GetMimeTypeProperties(typeof(Text));
            }
        }
    }
}