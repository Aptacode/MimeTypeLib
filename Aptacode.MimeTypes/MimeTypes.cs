using System.Collections.Generic;

namespace Aptacode.MimeTypes
{
    public static class MimeTypes
    {
        //Dictionary containing each MimeType and their compatible extensions
        private static readonly Dictionary<string, MimeType> MimeTypeDictionary = new Dictionary<string, MimeType>()
        {
            //Application
            { ".pdf", Application.Pdf},
            { ".json", Application.Json},

            //Text
            { ".html", Text.Html},
            { ".rtf", Text.Richtext},
            { ".txt", Text.Plain},

            //Image 
            {".apng", Image.Apng},
            {".bmp", Image.Bmp},
            {".gif", Image.Gif},
            {".ico", Image.Ico},
            {".cur", Image.Ico},
            {".jpg", Image.Jpeg},
            {".jpeg", Image.Jpeg},
            {".jfif", Image.Jpeg},
            {".pjpeg", Image.Jpeg},
            {".pjp", Image.Jpeg},
            {".png", Image.Png},
            {".svg", Image.Svg},
            {".tif", Image.Tiff},
            {".tiff", Image.Tiff},
            {".webp", Image.WebP},

        };

        public static MimeType Get(string extension)
        {
            if (!MimeTypeDictionary.TryGetValue(extension, out var mimeType))
            {
                mimeType = MimeType.None;
            }

            return mimeType;
        }

        public static void Set(string extension, MimeType mimeType)
        {
            MimeTypeDictionary[extension] = mimeType;
        }

        public static class Application
        {
            private const string Type = nameof(Application);

            public static MimeType Pdf { get; } = new MimeType(Type,nameof(Pdf));
            public static MimeType Json { get; } = new MimeType(Type, nameof(Json));
        }

        public static class Image
        {
            private const string Type = nameof(Image);
            public static MimeType Apng { get; } = new MimeType(Type, nameof(Apng));
            public static MimeType Bmp { get; } = new MimeType(Type, nameof(Bmp));
            public static MimeType Gif { get; } = new MimeType(Type, nameof(Gif));
            public static MimeType Ico { get; } = new MimeType(Type, nameof(Ico));
            public static MimeType Jpeg { get; } = new MimeType(Type, nameof(Jpeg));
            public static MimeType Png { get; } = new MimeType(Type, nameof(Png));
            public static MimeType Svg { get; } = new MimeType(Type, nameof(Svg));
            public static MimeType Tiff { get; } = new MimeType(Type, nameof(Tiff));
            public static MimeType WebP { get; } = new MimeType(Type, nameof(WebP));

        }

        public static class Audio
        {
            private const string Type = nameof(Audio);
            public static MimeType Wave { get; } = new MimeType(Type, nameof(Wave));
            public static MimeType Wav { get; } = new MimeType(Type, nameof(Wav));
        }

        public static class Video
        {
            private const string Type = nameof(Video);
            public static MimeType Webm { get; } = new MimeType(Type, nameof(Webm));
        }


        public static class Text
        {
            private const string Type = nameof(Text);
            public static MimeType Html { get; } = new MimeType(Type, nameof(Html));
            public static MimeType Plain { get; } = new MimeType(Type, nameof(Plain));
            public static MimeType Richtext { get; } = new MimeType(Type, nameof(Richtext));
        }
    }
}
