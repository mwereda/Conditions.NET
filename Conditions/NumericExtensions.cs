using System;

namespace Conditions
{
    public static class NumericExtensions
    {
        private const int Greater = 1;
        private const int Equal = 0;
        private const int Lower = -1;

        /// <summary>
        /// Checks if value is greater than given value.
        /// </summary>                
        /// <param name="givenValue">Value which variable should be greater than.</param>
        /// <returns>Boolean value indicating if variable is greater than given value.</returns>
        public static ConditionResult IsGreaterThan<T>(this T value, T givenValue) where T : struct, IComparable<T>
        {
            return ConditionResult.Create(value.CompareTo(givenValue).Equals(Greater));
        }

        /// <summary>
        /// Checks if value is greater than or equal given value.
        /// </summary>                
        /// <param name="givenValue">Value which variable should be greater than or equal to.</param>
        /// <returns>Boolean value indicating if variable is greater than or equal given value.</returns>
        public static ConditionResult IsGreaterOrEqual<T>(this T value, T givenValue) where T : struct, IComparable<T>
        {
            var result = value.CompareTo(givenValue).Equals(Greater) || value.CompareTo(givenValue).Equals(Equal);

            return ConditionResult.Create(result);
        }

        /// <summary>
        /// Checks if value is lower than given value.
        /// </summary>                
        /// <param name="givenValue">Value which variable should be lower than.</param>
        /// <returns>Boolean value indicating if variable is lower than given value.</returns>        
        public static ConditionResult IsLowerThan<T>(this T value, T givenValue) where T : struct, IComparable<T>
        {
            return ConditionResult.Create(value.CompareTo(givenValue).Equals(Lower));
        }

        /// <summary>
        /// Checks if value is lower than or equal given value.
        /// </summary>                
        /// <param name="givenValue">Value which variable should be lower than or equal to.</param>
        /// <returns>Boolean value indicating if variable is lower than or equal given value.</returns>
        public static ConditionResult IsLowerOrEqual<T>(this T value, T givenValue) where T : struct, IComparable<T>
        {
            var result = value.CompareTo(givenValue).Equals(Lower) || value.CompareTo(givenValue).Equals(Equal);

            return ConditionResult.Create(result);
        }

        /// <summary>
        /// Checks if value is between given range.
        /// </summary>                
        /// <param name="minValue">Minimal value.</param>
        /// <param name="maxValue">Maximal value.</param>
        /// <returns>Boolean value indicating if variable is between given range.</returns>
        public static ConditionResult IsBetween<T>(this T value, T minValue, T maxValue) where T : struct, IComparable<T>
        {
            var result = value.IsGreaterOrEqual(minValue) && value.IsLowerOrEqual(maxValue);

            return ConditionResult.Create(result);
        }

        /// <summary>
        /// Checks if value is positive.
        /// </summary>        
        /// <param name="value">Given value.</param>
        /// <returns>Boolean value indicating if variable is positive number.</returns>
        public static ConditionResult IsPositive<T>(this T value) where T : struct, IComparable<T>
        {
            return ConditionResult.Create(value.CompareTo(default(T)).Equals(Greater));
        }

        /// <summary>
        /// Checks if value is negative.
        /// </summary>        
        /// <param name="value">Given value.</param>
        /// <returns>Boolean value whether variable is negative number.</returns>
        public static ConditionResult IsNegative<T>(this T value) where T : struct, IComparable<T>
        {
            return ConditionResult.Create(value.CompareTo(default(T)).Equals(Lower));
        }
    }
}
