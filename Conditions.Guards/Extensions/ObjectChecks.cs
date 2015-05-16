using System;

// ReSharper disable once CheckNamespace
namespace Conditions.Guards
{
    public static class ObjectChecks
    {
        /// <summary>
        /// Guards against object that is not null.
        /// </summary>       
        public static void IsNull<T>(this If<T> ifObject) where T : class
        {
            if (ifObject.Value.IsNotNull())
            {
                throw new ArgumentException(ifObject.ParamName);
            }
        }

        /// <summary>
        /// Guards against object that is null.
        /// </summary>       
        public static void IsNotNull<T>(this If<T> ifObject) where T : class
        {
            if (ifObject.Value.IsNull())
            {
                throw new ArgumentNullException(ifObject.ParamName);
            }
        }
    }
}
