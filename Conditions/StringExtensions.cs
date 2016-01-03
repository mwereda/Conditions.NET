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
        public static ConditionResult<string> IsNullOrEmpty(this String @string)
        {
            return ConditionResult<string>.Create(string.IsNullOrEmpty(@string), @string);
        }

        /// <summary>
        /// Checks if string is null or empty.
        /// </summary>        
        /// <returns>Boolean value indicating if string is null or empty.</returns>
        public static ConditionResult<string> IsNullOrEmpty(this ComplexCondition<string> complexCondition)
        {
            var value = complexCondition.Value;
            var result = value.IsNullOrEmpty();

            return ConditionResult<string>.Create(complexCondition.CalculateResult(result), value);
        }

        /// <summary>
        /// Checks if string is not null or empty.
        /// </summary>        
        /// <returns>Boolean value indicating if string is not null or empty.</returns>
        public static ConditionResult<string> IsNotNullOrEmpty(this String @string)
        {
            return ConditionResult<string>.Create(!IsNullOrEmpty(@string), @string);
        }

        /// <summary>
        /// Checks if string is not null or empty.
        /// </summary>        
        /// <returns>Boolean value indicating if string is not null or empty.</returns>
        public static ConditionResult<string> IsNotNullOrEmpty(this ComplexCondition<string> complexCondition)
        {
            var value = complexCondition.Value;
            var result = value.IsNotNullOrEmpty();

            return ConditionResult<string>.Create(complexCondition.CalculateResult(result), value);
        }

        /// <summary>
        /// Checks if string is valid GUID.
        /// </summary>        
        /// <returns>Boolean value indicating if string is valid GUID.</returns>
        public static ConditionResult<string> IsGuid(this String @string)
        {
            var guidPattern = new Regex(
                "^[A-Fa-f0-9]{32}$|" +
                "^({|\\()?[A-Fa-f0-9]{8}-([A-Fa-f0-9]{4}-){3}[A-Fa-f0-9]{12}(}|\\))?$|" +
                "^({)?[0xA-Fa-f0-9]{3,10}(, {0,1}[0xA-Fa-f0-9]{3,6}){2}, {0,1}({)([0xA-Fa-f0-9]{3,4}, {0,1}){7}[0xA-Fa-f0-9]{3,4}(}})$");
            var match = guidPattern.Match(@string);

            return ConditionResult<string>.Create(match.Success, @string);
        }

        /// <summary>
        /// Checks if string is valid GUID.
        /// </summary>        
        /// <returns>Boolean value indicating if string is valid GUID.</returns>
        public static ConditionResult<string> IsGuid(this ComplexCondition<string> complexCondition)
        {
            var value = complexCondition.Value;
            var result = value.IsGuid();

            return ConditionResult<string>.Create(complexCondition.CalculateResult(result), value);
        }

        /// <summary>
        /// Checks if string is valid email address.
        /// </summary>        
        /// <returns>Boolean value indicating if string is valid email address.</returns>
        public static ConditionResult<string> IsEmailAddress(this String @string)
        {
            try
            {
                new MailAddress(@string);

                return ConditionResult<string>.Create(true, @string);
            }
            catch
            {
                return ConditionResult<string>.Create(false, @string);
            }
        }

        /// <summary>
        /// Checks if string is valid email address.
        /// </summary>        
        /// <returns>Boolean value indicating if string is valid email address.</returns>
        public static ConditionResult<string> IsEmailAddress(this ComplexCondition<string> complexCondition)
        {
            var value = complexCondition.Value;
            var result = value.IsEmailAddress();

            return ConditionResult<string>.Create(complexCondition.CalculateResult(result), value);
        }

        /// <summary>
        /// Checks if string has expected length.
        /// </summary>        
        /// <param name="expectedLength">Expected string length.</param>
        /// <returns>Boolean value indicating if string has expected length.</returns>
        public static ConditionResult<string> HasLength(this String @string, int expectedLength)
        {
            return ConditionResult<string>.Create(@string.Length.Equals(expectedLength), @string);
        }

        /// <summary>
        /// Checks if string has expected length.
        /// </summary>        
        /// <param name="expectedLength">Expected string length.</param>
        /// <returns>Boolean value indicating if string has expected length.</returns>
        public static ConditionResult<string> HasLength(this ComplexCondition<string> complexCondition, int expectedLength)
        {
            var value = complexCondition.Value;
            var result = value.HasLength(expectedLength);

            return ConditionResult<string>.Create(complexCondition.CalculateResult(result), value);
        }

        /// <summary>
        /// Checks if string has minimal length of given value.
        /// </summary>        
        /// <param name="minimalLength">Minimal length</param>
        /// <returns>Boolean value indicating if string has minimal length.</returns>
        public static ConditionResult<string> HasLengthAtLeast(this String @string, int minimalLength)
        {
            return ConditionResult<string>.Create(@string.Length.IsGreaterOrEqual(minimalLength), @string);
        }

        /// <summary>
        /// Checks if string has minimal length of given value.
        /// </summary>        
        /// <param name="minimalLength">Minimal length</param>
        /// <returns>Boolean value indicating if string has minimal length.</returns>
        public static ConditionResult<string> HasLengthAtLeast(this ComplexCondition<string> complexCondition, int minimalLength)
        {
            var value = complexCondition.Value;
            var result = value.HasLengthAtLeast(minimalLength);

            return ConditionResult<string>.Create(complexCondition.CalculateResult(result), value);
        }

        /// <summary>
        /// Checks if string matches pattern (RegEx).
        /// </summary>        
        /// <param name="pattern">Regular expression pattern.</param>
        /// <returns>Boolean value indicating if string matches given pattern</returns>
        public static ConditionResult<string> Matches(this String @string, string pattern)
        {
            return ConditionResult<string>.Create(Regex.IsMatch(@string, pattern), @string);
        }

        /// <summary>
        /// Checks if string matches pattern (RegEx).
        /// </summary>        
        /// <param name="pattern">Regular expression pattern.</param>
        /// <returns>Boolean value indicating if string matches given pattern</returns>
        public static ConditionResult<string> Matches(this ComplexCondition<string> complexCondition, string pattern)
        {
            var value = complexCondition.Value;
            var result = value.Matches(pattern);

            return ConditionResult<string>.Create(complexCondition.CalculateResult(result), value);
        }
    }
}
