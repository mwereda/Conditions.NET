using System;

namespace Conditions
{
    public static class BoolExtensions
    {
        /// <summary>
        /// Checks if boolean value is true.
        /// </summary>        
        /// <returns>Boolean value indicating if boolean value is true.</returns>
        public static ConditionResult<bool> IsTrue(this Boolean value)
        {
            return ConditionResult<bool>.Create(value.Equals(true), value);
        }

        /// <summary>
        /// Checks if boolean value is false.
        /// </summary>        
        /// <returns>Boolean value indicating if boolean value is false.</returns>
        public static ConditionResult<bool> IsFalse(this Boolean value)
        {
            return ConditionResult<bool>.Create(value.Equals(false), value);
        }
    }
}
