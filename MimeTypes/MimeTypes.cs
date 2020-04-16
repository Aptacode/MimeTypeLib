using System;
using System.Collections.Generic;
using System.Linq;

namespace Aptacode.MimeTypes
{
    public static partial class MimeTypes
    {
        public static IEnumerable<MimeType> All()
        {
            return ExtensionDictionary.Keys.Distinct();
        }

        public static IEnumerable<MimeType> Get(string extension)
        {
            return ExtensionDictionary.Where(pair => pair.Value.Contains(extension)).Select(pair => pair.Key);
        }

        public static void Add(MimeType mimeType, params string[] extensions)
        {
            if (!ExtensionDictionary.TryGetValue(mimeType, out var extensionSet))
            {
                extensionSet = new HashSet<string>();
                ExtensionDictionary.Add(mimeType, extensionSet);
            }

            foreach (var extension in extensions)
            {
                extensionSet.Add(extension);
            }
        }

        internal static IEnumerable<MimeType> GetMimeTypeProperties(Type type)
        {
            return type.GetProperties().Select(p => p.GetValue(null, null) as MimeType).Where(p => p != null);
        }

        #region Extensions

        public static class Extensions
        {
            public static IEnumerable<string> All()
            {
                return ExtensionDictionary.Values.Select(hs => hs.ToList()).Aggregate((a, b) => a.Concat(b).ToList())
                    .Distinct();
            }

            public static IEnumerable<string> All(MimeType mimeType)
            {
                return ExtensionDictionary.TryGetValue(mimeType, out var extensionSet)
                    ? extensionSet.ToList()
                    : new List<string>();
            }
        }

        #endregion
    }
}