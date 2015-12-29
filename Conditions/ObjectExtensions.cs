using System;

namespace Conditions
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// Checks if object is null.
        /// </summary>        
        /// <returns>Boolean value indicating if object is null.</returns>
        public static ConditionResult IsNull(this Object @object)
        {
            return ConditionResult.Create(@object == null);
        }

        /// <summary>
        /// Checks if object is not null.
        /// </summary>        
        /// <returns>Boolean value indicating if object is not null.</returns>
        public static ConditionResult IsNotNull(this Object @object)
        {
            return ConditionResult.Create(!IsNull(@object));
        }
    }
}
