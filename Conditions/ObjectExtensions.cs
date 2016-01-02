using System;

namespace Conditions
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// Checks if object is null.
        /// </summary>        
        /// <returns>Boolean value indicating if object is null.</returns>
        public static ConditionResult<object> IsNull(this Object @object)
        {
            return ConditionResult<object>.Create(@object == null, @object);
        }

        /// <summary>
        /// Checks if object is not null.
        /// </summary>        
        /// <returns>Boolean value indicating if object is not null.</returns>
        public static ConditionResult<object> IsNotNull(this Object @object)
        {
            return ConditionResult<object>.Create(!IsNull(@object), @object);
        }
    }
}
