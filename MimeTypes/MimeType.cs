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

        #endregion

        #region Properties

        public string Type { get; }
        public string Subtype { get; }
        public static MimeType None { get; } = new MimeType(string.Empty, string.Empty);

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
            return components.Length < 2 ? None : new MimeType(components[0], components[1]);
        }

        #endregion

        #region IEquatable

        public override int GetHashCode() => (Type, Subtype).GetHashCode();

        public override bool Equals(object obj)
        {
            return obj is MimeType mimeType && Equals(mimeType);
        }

        public bool Equals(MimeType other) => this == other;

        public static bool operator == (MimeType lhs, MimeType rhs)
        {
            return lhs?.Type == rhs?.Type && lhs?.Subtype == rhs?.Subtype;
        }

        public static bool operator !=(MimeType lhs, MimeType rhs) => !(lhs == rhs);

        #endregion
    }
}