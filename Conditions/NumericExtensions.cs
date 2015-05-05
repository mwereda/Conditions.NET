using System;

namespace Conditions
{
    public static class NumericExtensions
    {
        /// <summary>
        /// Checks if value is greater than given value.
        /// </summary>                
        /// <param name="givenValue">Value which variable should be greater than.</param>
        /// <returns>Boolean value whether variable is greater than given value.</returns>
        public static bool IsGreaterThan<T>(this T value, T givenValue) where T : struct, IComparable<T>
        {
            return value.CompareTo(givenValue).Equals(1);
        }

        /// <summary>
        /// Checks if value is greater than or equal given value.
        /// </summary>                
        /// <param name="givenValue">Value which variable should be greater than or equal to.</param>
        /// <returns>Boolean value whether variable is greater than or equal given value.</returns>
        public static bool IsGreaterOrEqual<T>(this T value, T givenValue) where T : struct, IComparable<T>
        {
            return value.CompareTo(givenValue).Equals(1) || value.CompareTo(givenValue).Equals(0);
        }
    }
}
