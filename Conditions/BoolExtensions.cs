using System;

namespace Conditions
{
    public static class BoolExtensions
    {
        /// <summary>
        /// Checks if boolean value is true.
        /// </summary>        
        /// <returns>Boolean value indicating if boolean value is true.</returns>
        public static ConditionResult IsTrue(this Boolean value)
        {
            return ConditionResult.Create(value.Equals(true));
        }

        /// <summary>
        /// Checks if boolean value is false.
        /// </summary>        
        /// <returns>Boolean value indicating if boolean value is false.</returns>
        public static ConditionResult IsFalse(this Boolean value)
        {
            return ConditionResult.Create(value.Equals(false));
        }
    }
}
