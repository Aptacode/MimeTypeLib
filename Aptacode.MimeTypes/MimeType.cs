using System;

namespace Aptacode.MimeTypes
{
    public class MimeType : IEquatable<MimeType>
    {
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

        public string Type { get; }
        public string Subtype { get; }

        public static MimeType None { get; } = new MimeType();

        public static MimeType Parse(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return None;
            }

            var components = input.Split('/');
            if (components.Length < 2)
            {
                return None;
            }

            return new MimeType(components[0], components[1]);
        }

        public override string ToString()
        {
            return $"{Type}/{Subtype}";
        }

        #region Equality

        public override int GetHashCode()
        {
            return (Type, Subtype).GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj is MimeType other && Equals(other);
        }

        public bool Equals(MimeType other)
        {
            return other != null && Type.Equals(other.Type) && Subtype.Equals(other.Subtype);
        }

        #endregion Equality
    }
}