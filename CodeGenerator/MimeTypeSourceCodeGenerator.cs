using System.Linq;
using System.Text;

namespace Aptacode.MimeTypes.SourceCodeGenerator
{
    public class MimeTypeSourceCodeGenerator
    {
        public string GenerateMimeTypeGroups(MimeTypeDictionary mimeTypeDictionary)
        {
            var sourceCodeBuilder = new StringBuilder();

            foreach (var mimeGroup in mimeTypeDictionary.All())
            {
                sourceCodeBuilder.AppendLine(GetMimeTypePartialClassSouceCode(mimeGroup));
            }

            return FillOutMimeTypeGroupTemplate(sourceCodeBuilder.ToString());
        }

        public string GenerateMimeTypeExtensions(MimeTypeDictionary mimeTypeDictionary)
        {
            var subtypeSourceCode = new StringBuilder();
            foreach (var group in mimeTypeDictionary.All())
            {
                foreach (var subType in group.All())
                {
                    var extensions = string.Join(",", subType.All().Select(e => $"\"{e}\""));
                    subtypeSourceCode.AppendLine(
                        $"            {{{subType.LegalTypeName}.{subType.LegalSubTypeName}, new HashSet<string>(){{{extensions}}}}},");
                }
            }

            return FillOutMimeTypeExtensionTemplate(subtypeSourceCode.ToString());
        }

        private string FillOutMimeTypeGroupTemplate(string contents)
        {
            return $@"using System.Collections.Generic;

namespace Aptacode.MimeTypes
{{
    public static partial class MimeTypes
    {{
{contents}
    }}
}}
";
        }

        private string FillOutMimeTypeExtensionTemplate(string contents)
        {
            return $@"using System.Collections.Generic;

namespace Aptacode.MimeTypes
{{
    public static partial class MimeTypes
    {{
        //Dictionary containing each MimeType and their compatible extensions
        private static readonly Dictionary<MimeType, HashSet<string>> ExtensionDictionary =
            new Dictionary<MimeType, HashSet<string>>
            {{
                //Na
                {{MimeType.None, new HashSet<string>()}},
{contents}
            }};
    }}
}}
";
        }

        private static string GetMimeTypePartialClassSouceCode(MimeTypeGroup group)
        {
            var subtypeSourceCode = new StringBuilder();
            foreach (var subType in group.All())
            {
                subtypeSourceCode.AppendLine(
                    $"            public static MimeType {subType.LegalSubTypeName} {{ get; }} = new MimeType(\"{subType.TypeName}\", \"{subType.SubTypeName}\");");
            }


            return
                $@"
        public static class {group.LegalTypeName}
        {{
            public const string Type = ""{group.TypeName}""; 
                
{subtypeSourceCode}

            public static IEnumerable<MimeType> All()
            {{
                return GetMimeTypeProperties(typeof(Application));
            }}
        }}
";
        }
    }
}