using System.Collections.Generic;

namespace Aptacode.MimeTypes.SourceCodeGenerator
{
    public class MimeType
    {
        private readonly HashSet<string> _extensions = new HashSet<string>();

        public MimeType(string typeName, string subTypeName)
        {
            TypeName = typeName;
            SubTypeName = subTypeName;
        }

        public string TypeName { get; set; }
        public string SubTypeName { get; set; }
        public string LegalTypeName => TypeName.ToClassName();
        public string LegalSubTypeName => SubTypeName.ToClassName();

        public IEnumerable<string> All()
        {
            return _extensions;
        }

        public void Add(string extension)
        {
            _extensions.Add(extension);
        }
    }
}