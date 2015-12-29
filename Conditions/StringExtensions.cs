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
        /// <returns>Boolean value indicating if string is null or empty.</returns>
        public static ConditionResult IsNullOrEmpty(this String @string)
        {
            return ConditionResult.Create(string.IsNullOrEmpty(@string));
        }

        /// <summary>
        /// Checks if string is not null or empty.
        /// </summary>        
        /// <returns>Boolean value indicating if string is not null or empty.</returns>
        public static ConditionResult IsNotNullOrEmpty(this String @string)
        {
            return ConditionResult.Create(!IsNullOrEmpty(@string));
        }

        /// <summary>
        /// Checks if string is valid GUID.
        /// </summary>        
        /// <returns>Boolean value indicating if string is valid GUID.</returns>
        public static ConditionResult IsGuid(this String @string)
        {
            var guidPattern = new Regex(
                "^[A-Fa-f0-9]{32}$|" +
                "^({|\\()?[A-Fa-f0-9]{8}-([A-Fa-f0-9]{4}-){3}[A-Fa-f0-9]{12}(}|\\))?$|" +
                "^({)?[0xA-Fa-f0-9]{3,10}(, {0,1}[0xA-Fa-f0-9]{3,6}){2}, {0,1}({)([0xA-Fa-f0-9]{3,4}, {0,1}){7}[0xA-Fa-f0-9]{3,4}(}})$");
            var match = guidPattern.Match(@string);

            return ConditionResult.Create(match.Success);
        }

        /// <summary>
        /// Checks if string is valid email address.
        /// </summary>        
        /// <returns>Boolean value indicating if string is valid email address.</returns>
        public static ConditionResult IsEmailAddress(this String @string)
        {
            try
            {
                new MailAddress(@string);

                return ConditionResult.Create(true);
            }
            catch
            {
                return ConditionResult.Create(false);
            }
        }

        /// <summary>
        /// Checks if string has expected length.
        /// </summary>        
        /// <param name="expectedLength">Expected string length.</param>
        /// <returns>Boolean value indicating if string has expected length.</returns>
        public static ConditionResult HasLength(this String @string, int expectedLength)
        {
            return ConditionResult.Create(@string.Length.Equals(expectedLength));
        }

        /// <summary>
        /// Checks if string has minimal length of given value.
        /// </summary>        
        /// <param name="minimalLength">Minimal length</param>
        /// <returns>Boolean value indicating if string has minimal length.</returns>
        public static ConditionResult HasLengthAtLeast(this String @string, int minimalLength)
        {
            return ConditionResult.Create(@string.Length.IsGreaterOrEqual(minimalLength));
        }

        /// <summary>
        /// Checks if string matches pattern (RegEx)
        /// </summary>        
        /// <param name="pattern">Regular expression pattern.</param>
        /// <returns>Boolean value indicating if string matches given pattern</returns>
        public static ConditionResult Matches(this String @string, string pattern)
        {
            return ConditionResult.Create(Regex.IsMatch(@string, pattern));
        }
    }
}
