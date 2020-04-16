using System.Globalization;
using System.Text;

namespace Aptacode.MimeTypes.SourceCodeGenerator
{
    public static class StringExtensions
    {
        public static string ToClassName(this string input)
        {
            var outputBuilder = new StringBuilder();

            outputBuilder.Append(ToValidChar(input[0], true));
            for (var i = 1; i < input.Length; i++)
            {
                outputBuilder.Append(ToValidChar(input[i], false));
            }

            return outputBuilder.ToString();
        }

        private static char ToValidChar(char c, bool isFirstChar)
        {
            if (isFirstChar)
            {
                c = char.ToUpper(c);
            }

            return IsValidInIdentifier(c, isFirstChar) ? c : '_';
        }

        private static bool IsValidInIdentifier(char c, bool isFirstChar)
        {
            switch (char.GetUnicodeCategory(c))
            {
                case UnicodeCategory.UppercaseLetter:
                case UnicodeCategory.LowercaseLetter:
                case UnicodeCategory.TitlecaseLetter:
                case UnicodeCategory.ModifierLetter:
                case UnicodeCategory.OtherLetter:
                    // Always allowed in C# identifiers
                    return true;

                case UnicodeCategory.LetterNumber:
                case UnicodeCategory.NonSpacingMark:
                case UnicodeCategory.SpacingCombiningMark:
                case UnicodeCategory.DecimalDigitNumber:
                case UnicodeCategory.ConnectorPunctuation:
                case UnicodeCategory.Format:
                    // Only allowed after first char
                    return !isFirstChar;
                default:
                    return false;
            }
        }
    }
}