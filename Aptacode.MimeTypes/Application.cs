using System.Collections.Generic;

namespace Aptacode.MimeTypes
{
    public static partial class MimeTypes
    {
        public class Application
        {
            public const string Type = nameof(Application);

            public static MimeType Pdf { get; } = new MimeType(Type, nameof(Pdf));
            public static MimeType Json { get; } = new MimeType(Type, nameof(Json));

            public static IEnumerable<MimeType> All()
            {
                return GetMimeTypeProperties(typeof(Application));
            }
        }
    }
}