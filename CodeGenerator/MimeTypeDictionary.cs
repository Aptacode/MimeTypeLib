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
            if (!_mimeTypeDictionary.TryGetValue(type, out var mimeGroup))
            {
                mimeGroup = new MimeTypeGroup(type);
                _mimeTypeDictionary.Add(type, mimeGroup);
            }

            mimeGroup.Add(subtype, extension);
        }
    }
}