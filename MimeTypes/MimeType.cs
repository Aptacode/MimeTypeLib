using System;

namespace Aptacode.MimeTypes
{
    public class MimeType : IEquatable<MimeType>
    {
        #region Constructors

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

        #endregion

        #region Properties

        public string Type { get; set; }
        public string Subtype { get; set; }
        public static MimeType None { get; } = new MimeType();

        #endregion

        #region ToString

        public override string ToString()
        {
            return $"{Type}/{Subtype}";
        }

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

        #endregion

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