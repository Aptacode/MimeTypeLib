namespace Aptacode.MimeTypes
{
    public class MimeType
    {
        public string Type { get; }
        public string Subtype { get; }
        public string Name => $"{Type}/{Subtype}";

        public MimeType(string type, string subtype)
        {
            Type = type.ToLower();
            Subtype = subtype.ToLower();
        }

        public MimeType()
        {
            Type = string.Empty;
            Subtype = string.Empty;
        }

        public static MimeType None { get; } = new MimeType();
    }
}