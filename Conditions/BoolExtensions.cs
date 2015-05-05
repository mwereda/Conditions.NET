using System;

namespace Conditions
{
    public static class BoolExtensions
    {
        /// <summary>
        /// Checks if boolean value is true.
        /// </summary>        
        /// <returns>Boolean value whether boolean value is true.</returns>
        public static bool IsTrue(this Boolean value)
        {
            return value.Equals(true);
        }

        /// <summary>
        /// Checks if boolean value is false.
        /// </summary>        
        /// <returns>Boolean value whether boolean value is false.</returns>
        public static bool IsFalse(this Boolean value)
        {
            return value.Equals(false);
        }
    }
}
