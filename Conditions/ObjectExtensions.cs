using System;

namespace Conditions
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// Checks if object is null.
        /// </summary>        
        /// <returns>Boolean value indicating if object is null.</returns>
        public static bool IsNull(this Object @object)
        {
            return @object == null;
        }

        /// <summary>
        /// Checks if object is not null.
        /// </summary>        
        /// <returns>Boolean value indicating if object is not null.</returns>
        public static bool IsNotNull(this Object @object)
        {
            return !IsNull(@object);
        }
    }
}
