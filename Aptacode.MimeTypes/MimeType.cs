namespace Aptacode.MimeTypes
{
    public class MimeType
    {
        public string Type { get; }
        public string Subtype { get; }

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

        public static MimeType Parse(string input)
        {
            if (string.IsNullOrEmpty(input))
                return None;

            var components = input.Split('/');
            if (components.Length < 2)
                return None;

            return new MimeType(components[0], components[1]);
        }

        public override string ToString() => $"{Type}/{Subtype}";
    }
}