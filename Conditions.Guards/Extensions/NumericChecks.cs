using System;

// ReSharper disable once CheckNamespace
namespace Conditions.Guards
{
    public static class NumericChecks
    {
        /// <summary>
        /// Guards against values lower or equal than given value.
        /// </summary>                
        /// <param name="givenValue">Given value.</param>        
        public static void IsGreaterThan<T>(this If<T> ifObject, T givenValue) where T : struct, IComparable<T>
        {
            if (ifObject.Value.IsLowerOrEqual(givenValue))
            {
                throw new ArgumentException(string.Format("Value should be greater than {0}.", givenValue),
                    ifObject.ParamName);
            }
        }

        /// <summary>
        /// Guards against values lower than given value.
        /// </summary>               
        /// <param name="minimalValue">Expected minimal value.</param>
        public static void IsGreaterOrEqual<T>(this If<T> ifObject, T minimalValue) where T : struct, IComparable<T>
        {
            if (ifObject.Value.IsLowerThan(minimalValue))
            {
                throw new ArgumentException(string.Format("Value should be greater than or equal {0}.", minimalValue),
                    ifObject.ParamName);
            }
        }

        /// <summary>
        /// Guards against values higher than or equal given value.
        /// </summary>                
        /// <param name="givenValue">Given value.</param>
        public static void IsLowerThan<T>(this If<T> ifObject, T givenValue) where T : struct, IComparable<T>
        {
            if (ifObject.Value.IsGreaterOrEqual(givenValue))
            {
                throw new ArgumentException(string.Format("Value should be lower than {0}.", givenValue),
                    ifObject.ParamName);
            }
        }

        /// <summary>
        /// Guards against values greater than maximal value.
        /// </summary>                
        /// <param name="maximalValue">Maximal value.</param>
        public static void IsLowerOrEqual<T>(this If<T> ifObject, T maximalValue) where T : struct, IComparable<T>
        {
            if (ifObject.Value.IsGreaterThan(maximalValue))
            {
                throw new ArgumentException(string.Format("Value should be lower than or equal {0}.", maximalValue),
                    ifObject.ParamName);
            }
        }

        /// <summary>
        /// Guards against values not in given range.
        /// </summary>
        /// <param name="minimalValue">Minmal expected value.</param>
        /// <param name="maximalValue">Maximal expected value.</param>
        public static void IsBetween<T>(this If<T> ifObject, T minimalValue, T maximalValue)
            where T : struct, IComparable<T>
        {
            if (!ifObject.Value.IsBetween(minimalValue, maximalValue))
            {
                throw new ArgumentException(
                    string.Format("Value should be in range ({0},{1}", minimalValue, maximalValue), ifObject.ParamName);
            }
        }
    }
}
