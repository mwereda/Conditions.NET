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
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against object that is null.
        /// </summary>       
        public static void IsNotNull<T>(this If<T> ifObject) where T : class
        {
            if (ifObject.Value.IsNull())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentNullException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }
    }
}
