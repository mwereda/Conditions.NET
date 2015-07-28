using System;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace Conditions.Guards
{
    public static class EnumerableChecks
    {
        /// <summary>
        /// Guards against not empty collections.
        /// </summary> 
        public static void IsEmpty<T>(this If<List<T>> ifObject)
        {
            if (!ifObject.Value.IsEmpty())
            {
                throw new ArgumentException(ifObject.ParamName);
            }
        }

        /// <summary>
        /// Guards against not empty collections.
        /// </summary> 
        public static void IsEmpty<T>(this If<IList<T>> ifObject)
        {
            if (!ifObject.Value.IsEmpty())
            {
                throw new ArgumentException(ifObject.ParamName);
            }
        }

        /// <summary>
        /// Guards against not empty collections.
        /// </summary> 
        public static void IsEmpty<T>(this If<IEnumerable<T>> ifObject)
        {
            if (!ifObject.Value.IsEmpty())
            {
                throw new ArgumentException(ifObject.ParamName);
            }
        }

        /// <summary>
        /// Guards against not empty collections.
        /// </summary> 
        public static void IsEmpty<T>(this If<ICollection<T>> ifObject)
        {
            if (!ifObject.Value.IsEmpty())
            {
                throw new ArgumentException(ifObject.ParamName);
            }
        }

        /// <summary>
        /// Guards against empty collections.
        /// </summary> 
        public static void IsNotEmpty<T>(this If<List<T>> ifObject)
        {
            if (ifObject.Value.IsEmpty())
            {
                throw new ArgumentException(ifObject.ParamName);
            }
        }

        /// <summary>
        /// Guards against empty collections.
        /// </summary> 
        public static void IsNotEmpty<T>(this If<IList<T>> ifObject)
        {
            if (ifObject.Value.IsEmpty())
            {
                throw new ArgumentException(ifObject.ParamName);
            }
        }

        /// <summary>
        /// Guards against empty collections.
        /// </summary> 
        public static void IsNotEmpty<T>(this If<IEnumerable<T>> ifObject)
        {
            if (ifObject.Value.IsEmpty())
            {
                throw new ArgumentException(ifObject.ParamName);
            }
        }

        /// <summary>
        /// Guards against empty collections.
        /// </summary> 
        public static void IsNotEmpty<T>(this If<ICollection<T>> ifObject)
        {
            if (ifObject.Value.IsEmpty())
            {
                throw new ArgumentException(ifObject.ParamName);
            }
        }
    }
}
