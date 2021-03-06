﻿using System;
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
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against not empty collections.
        /// </summary> 
        public static void IsEmpty<T>(this If<IList<T>> ifObject)
        {
            if (!ifObject.Value.IsEmpty())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against not empty collections.
        /// </summary> 
        public static void IsEmpty<T>(this If<IEnumerable<T>> ifObject)
        {
            if (!ifObject.Value.IsEmpty())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against not empty collections.
        /// </summary> 
        public static void IsEmpty<T>(this If<ICollection<T>> ifObject)
        {
            if (!ifObject.Value.IsEmpty())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against empty collections.
        /// </summary> 
        public static void IsNotEmpty<T>(this If<List<T>> ifObject)
        {
            if (ifObject.Value.IsEmpty())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against empty collections.
        /// </summary> 
        public static void IsNotEmpty<T>(this If<IList<T>> ifObject)
        {
            if (ifObject.Value.IsEmpty())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against empty collections.
        /// </summary> 
        public static void IsNotEmpty<T>(this If<IEnumerable<T>> ifObject)
        {
            if (ifObject.Value.IsEmpty())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against empty collections.
        /// </summary> 
        public static void IsNotEmpty<T>(this If<ICollection<T>> ifObject)
        {
            if (ifObject.Value.IsEmpty())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against not null or empty collections.
        /// </summary> 
        public static void IsNullOrEmpty<T>(this If<List<T>> ifObject)
        {
            if (!ifObject.Value.IsNullOrEmpty())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against not null or empty collections.
        /// </summary> 
        public static void IsNullOrEmpty<T>(this If<IList<T>> ifObject)
        {
            if (!ifObject.Value.IsNullOrEmpty())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against not null or empty collections.
        /// </summary> 
        public static void IsNullOrEmpty<T>(this If<IEnumerable<T>> ifObject)
        {
            if (!ifObject.Value.IsNullOrEmpty())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against not null or empty collections.
        /// </summary> 
        public static void IsNullOrEmpty<T>(this If<ICollection<T>> ifObject)
        {
            if (!ifObject.Value.IsNullOrEmpty())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }


        /// <summary>
        /// Guards against null or empty collections.
        /// </summary> 
        public static void IsNotNullOrEmpty<T>(this If<List<T>> ifObject)
        {
            if (!ifObject.Value.IsNotNullOrEmpty())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against null or empty collections.
        /// </summary> 
        public static void IsNotNullOrEmpty<T>(this If<IList<T>> ifObject)
        {
            if (!ifObject.Value.IsNotNullOrEmpty())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against null or empty collections.
        /// </summary> 
        public static void IsNotNullOrEmpty<T>(this If<IEnumerable<T>> ifObject)
        {
            if (!ifObject.Value.IsNotNullOrEmpty())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against null or empty collections.
        /// </summary> 
        public static void IsNotNullOrEmpty<T>(this If<ICollection<T>> ifObject)
        {
            if (!ifObject.Value.IsNotNullOrEmpty())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have exactly one item.
        /// </summary> 
        public static void HasExactlyOneItem<T>(this If<List<T>> ifObject)
        {
            if (!ifObject.Value.HasExactlyOneItem())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have exactly one item.
        /// </summary> 
        public static void HasExactlyOneItem<T>(this If<IList<T>> ifObject)
        {
            if (!ifObject.Value.HasExactlyOneItem())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have exactly one item.
        /// </summary> 
        public static void HasExactlyOneItem<T>(this If<IEnumerable<T>> ifObject)
        {
            if (!ifObject.Value.HasExactlyOneItem())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have exactly one item.
        /// </summary> 
        public static void HasExactlyOneItem<T>(this If<ICollection<T>> ifObject)
        {
            if (!ifObject.Value.HasExactlyOneItem())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have more than one item.
        /// </summary> 
        public static void HasMoreThanOneItem<T>(this If<List<T>> ifObject)
        {
            if (!ifObject.Value.HasMoreThanOneItem())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have more than one item.
        /// </summary> 
        public static void HasMoreThanOneItem<T>(this If<IList<T>> ifObject)
        {
            if (!ifObject.Value.HasMoreThanOneItem())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have more than one item.
        /// </summary> 
        public static void HasMoreThanOneItem<T>(this If<IEnumerable<T>> ifObject)
        {
            if (!ifObject.Value.HasMoreThanOneItem())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have more than one item.
        /// </summary> 
        public static void HasMoreThanOneItem<T>(this If<ICollection<T>> ifObject)
        {
            if (!ifObject.Value.HasMoreThanOneItem())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have at least one item.
        /// </summary> 
        public static void HasAtLeastOneItem<T>(this If<List<T>> ifObject)
        {
            if (!ifObject.Value.HasAtLeastOneItem())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have at least one item.
        /// </summary> 
        public static void HasAtLeastOneItem<T>(this If<IList<T>> ifObject)
        {
            if (!ifObject.Value.HasAtLeastOneItem())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have at least one item.
        /// </summary> 
        public static void HasAtLeastOneItem<T>(this If<IEnumerable<T>> ifObject)
        {
            if (!ifObject.Value.HasAtLeastOneItem())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have at least one item.
        /// </summary> 
        public static void HasAtLeastOneItem<T>(this If<ICollection<T>> ifObject)
        {
            if (!ifObject.Value.HasAtLeastOneItem())
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have given number of items.
        /// </summary>        
        /// <param name="count">Expected items count.</param>
        public static void HasItemsCount<T>(this If<List<T>> ifObject, int count)
        {
            if (!ifObject.Value.HasItemsCount(count))
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have given number of items.
        /// </summary>        
        /// <param name="count">Expected items count.</param>
        public static void HasItemsCount<T>(this If<IList<T>> ifObject, int count)
        {
            if (!ifObject.Value.HasItemsCount(count))
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have given number of items.
        /// </summary>        
        /// <param name="count">Expected items count.</param>
        public static void HasItemsCount<T>(this If<IEnumerable<T>> ifObject, int count)
        {
            if (!ifObject.Value.HasItemsCount(count))
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have given number of items.
        /// </summary>        
        /// <param name="count">Expected items count.</param>
        public static void HasItemsCount<T>(this If<ICollection<T>> ifObject, int count)
        {
            if (!ifObject.Value.HasItemsCount(count))
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have at least given number of items.
        /// </summary>        
        /// <param name="count">Expected items count.</param>
        public static void HasItemsCountAtLeast<T>(this If<List<T>> ifObject, int count)
        {
            if (!ifObject.Value.HasItemsCountAtLeast(count))
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have at least given number of items.
        /// </summary>        
        /// <param name="count">Expected items count.</param>
        public static void HasItemsCountAtLeast<T>(this If<IList<T>> ifObject, int count)
        {
            if (!ifObject.Value.HasItemsCountAtLeast(count))
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have at least given number of items.
        /// </summary>        
        /// <param name="count">Expected items count.</param>
        public static void HasItemsCountAtLeast<T>(this If<IEnumerable<T>> ifObject, int count)
        {
            if (!ifObject.Value.HasItemsCountAtLeast(count))
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have at least given number of items.
        /// </summary>        
        /// <param name="count">Expected items count.</param>
        public static void HasItemsCountAtLeast<T>(this If<ICollection<T>> ifObject, int count)
        {
            if (!ifObject.Value.HasItemsCountAtLeast(count))
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have more items than given number.
        /// </summary>        
        /// <param name="count">Expected items count.</param>
        public static void HasMoreItemsThan<T>(this If<List<T>> ifObject, int count)
        {
            if (!ifObject.Value.HasMoreItemsThan(count))
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have more items than given number.
        /// </summary>        
        /// <param name="count">Expected items count.</param>
        public static void HasMoreItemsThan<T>(this If<IList<T>> ifObject, int count)
        {
            if (!ifObject.Value.HasMoreItemsThan(count))
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have more items than given number.
        /// </summary>        
        /// <param name="count">Expected items count.</param>
        public static void HasMoreItemsThan<T>(this If<IEnumerable<T>> ifObject, int count)
        {
            if (!ifObject.Value.HasMoreItemsThan(count))
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }

        /// <summary>
        /// Guards against collections that don't have more items than given number.
        /// </summary>        
        /// <param name="count">Expected items count.</param>
        public static void HasMoreItemsThan<T>(this If<ICollection<T>> ifObject, int count)
        {
            if (!ifObject.Value.HasMoreItemsThan(count))
            {
                if (!ifObject.ExceptionConfiguration.ExceptionOverriden)
                {
                    ifObject.ExceptionConfiguration.ThrowsException(() => new ArgumentException(ifObject.ParamName));
                }

                ifObject.ExceptionConfiguration.Throw();
            }
        }
    }
}
