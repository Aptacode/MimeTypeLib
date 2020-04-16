using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Aptacode.MimeTypes.SourceCodeGenerator
{
    internal class Program
    {
        private static readonly Regex MimetypesLineRegex =
            new Regex(@"(.+?)\/(.+?),(.*)", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        private static void Main(string[] args)
        {
            var mimeTypes = LoadMimeTypes();

            var sourceCodeGenerator = new MimeTypeSourceCodeGenerator();
            File.WriteAllText("./MimeTypeGroups.cs", sourceCodeGenerator.GenerateMimeTypeGroups(mimeTypes));
            File.WriteAllText("./MimeTypeExtensions.cs", sourceCodeGenerator.GenerateMimeTypeExtensions(mimeTypes));
        }

        private static MimeTypeDictionary LoadMimeTypes()
        {
            var mimeTypeDictionary = new MimeTypeDictionary();
            var entries = new List<(string, string, string)>();

            foreach (var entry in GetMimeTypeEntries())
            {
                var match = MimetypesLineRegex.Match(entry);

                if (!match.Success)
                {
                    continue;
                }


                var type = match.Groups[1].Value;
                var subtype = match.Groups[2].Value;
                var extension = match.Groups[3].Value;

                entries.Add((type, subtype, extension));

                mimeTypeDictionary.Add(type, subtype, extension);
            }

            return mimeTypeDictionary;
        }

        private static IEnumerable<string> GetMimeTypeEntries()
        {
            return File.ReadAllLines("./mimetypes.txt");
        }
    }
}