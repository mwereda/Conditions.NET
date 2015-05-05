using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Conditions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Checks if string is null or empty.
        /// </summary>        
        /// <returns>Boolean value whether string is null or empty.</returns>
        public static bool IsNullOrEmpty(this String @string)
        {
            return string.IsNullOrEmpty(@string);
        }

        /// <summary>
        /// Checks if string is not null or empty.
        /// </summary>        
        /// <returns>Boolean value whether string is not null or empty.</returns>
        public static bool IsNotNullOrEmpty(this String @string)
        {
            return !IsNullOrEmpty(@string);
        }

        /// <summary>
        /// Checks if string is valid GUID.
        /// </summary>        
        /// <returns>Boolean value whether string is valid GUID.</returns>
        public static bool IsGuid(this String @string)
        {
            var guidPattern = new Regex(
                "^[A-Fa-f0-9]{32}$|" +
                "^({|\\()?[A-Fa-f0-9]{8}-([A-Fa-f0-9]{4}-){3}[A-Fa-f0-9]{12}(}|\\))?$|" +
                "^({)?[0xA-Fa-f0-9]{3,10}(, {0,1}[0xA-Fa-f0-9]{3,6}){2}, {0,1}({)([0xA-Fa-f0-9]{3,4}, {0,1}){7}[0xA-Fa-f0-9]{3,4}(}})$");
            Match match = guidPattern.Match(@string);

            return match.Success;
        }

        /// <summary>
        /// Checks if string is valid email address.
        /// </summary>        
        /// <returns>Boolean value whether string is valid email address.</returns>
        public static bool IsEmailAddress(this String @string)
        {
            try
            {
                new MailAddress(@string);

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if string has expected length.
        /// </summary>        
        /// <param name="expectedLength">Expected string length.</param>
        /// <returns>Boolean value whether string has expected length.</returns>
        public static bool HasLength(this String @string, int expectedLength)
        {
            return @string.Length.Equals(expectedLength);
        }

        /// <summary>
        /// Checks if string has minimal length of given value.
        /// </summary>        
        /// <param name="minimalLength">Minimal length</param>
        /// <returns>Boolean value whether string has minimal length.</returns>
        public static bool HasLengthAtLeast(this String @string, int minimalLength)
        {
            return @string.Length.IsGreaterOrEqual(minimalLength);
        }
    }
}
