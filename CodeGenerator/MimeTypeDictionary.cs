using System.Collections.Generic;

namespace Aptacode.MimeTypes.SourceCodeGenerator
{
    public class MimeTypeDictionary
    {
        private readonly Dictionary<string, MimeTypeGroup>
            _mimeTypeDictionary = new Dictionary<string, MimeTypeGroup>();

        public IEnumerable<MimeTypeGroup> All()
        {
            return _mimeTypeDictionary.Values;
        }

        public void Add(string type, string subtype, string extension)
        {
            var typeKey = type.ToLower();

            if (!_mimeTypeDictionary.TryGetValue(typeKey, out var mimeGroup))
            {
                mimeGroup = new MimeTypeGroup(type);
                _mimeTypeDictionary.Add(typeKey, mimeGroup);
            }

            mimeGroup.Add(subtype, extension);
        }
    }
}