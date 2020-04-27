using System.Collections.Generic;

namespace Aptacode.MimeTypes.SourceCodeGenerator
{
    public class MimeTypeGroup
    {
        private readonly Dictionary<string, MimeType> _subTypeDictionary = new Dictionary<string, MimeType>();

        public MimeTypeGroup(string typeName)
        {
            TypeName = typeName;
        }

        public string TypeName { get; set; }
        public string LegalTypeName => TypeName.ToClassName();

        public IEnumerable<MimeType> All()
        {
            return _subTypeDictionary.Values;
        }

        public void Add(string subtype, string extension)
        {
            var subtypeKey = subtype.ToLower();

            if (!_subTypeDictionary.TryGetValue(subtypeKey, out var mimeType))
            {
                mimeType = new MimeType(TypeName, subtype);
                _subTypeDictionary.Add(subtypeKey, mimeType);
            }

            mimeType.Add(extension);
        }
    }
}