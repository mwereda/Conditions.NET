using System.Collections.Generic;
using System.Linq;

namespace Conditions
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Checks if collection (IEnumerable) is empty.
        /// </summary>        
        /// <returns>Boolean value indicating if collection is empty.</returns>
        public static bool IsEmpty<T>(this IEnumerable<T> collection)
        {
            return collection.Count() == 0;
        }

        /// <summary>
        /// Checks if collection (IEnumerable) is null or empty.
        /// </summary>        
        /// <returns>Boolean value indicating if collection is null or empty.</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> collection)
        {
            return collection == null || collection.IsEmpty();
        }

        /// <summary>
        /// Checks if collection (IEnumerable) is not null or empty.
        /// </summary>        
        /// <returns>Boolean value indicating if collection is not null or empty.</returns>
        public static bool IsNotNullOrEmpty<T>(this IEnumerable<T> collection)
        {
            return !collection.IsNullOrEmpty();
        }

        /// <summary>
        /// Checks if collection (IEnumerable) has only one item.
        /// </summary>        
        /// <returns>Boolean value indicating if collection has only one item.</returns>
        public static bool HasExactlyOneItem<T>(this IEnumerable<T> collection)
        {
            return collection.Count() == 1;
        }

        /// <summary>
        /// Checks if collection (IEnumerable) has more than one item.
        /// </summary>        
        /// <returns>Boolean value indicating if collection has more than one item.</returns>
        public static bool HasMoreThanOneItem<T>(this IEnumerable<T> collection)
        {
            return collection.Count() > 1;
        }

        /// <summary>
        /// Checks if collection (IEnumerable) has at least one item.
        /// </summary>        
        /// <returns>Boolean value indicating if collection has at least one item.</returns>
        public static bool HasAtLeastOneItem<T>(this IEnumerable<T> collection)
        {
            return collection.Count() >= 1;
        }

        /// <summary>
        /// Checks if collection (IEnumerable) has given number of items.
        /// </summary>        
        /// <param name="count">Items count.</param>
        /// <returns>Boolean value indicating if collection has given number of items.</returns>
        public static bool HasItemsCount<T>(this IEnumerable<T> collection, int count)
        {
            return collection.Count().Equals(count);
        }

        /// <summary>
        /// Checks if collection (IEnumerable) has at least given number of items.
        /// </summary>        
        /// <param name="count">Items count.</param>
        /// <returns>Boolean value indicating if collection has at least given number of items.</returns>
        public static bool HasItemsCountAtLeast<T>(this IEnumerable<T> collection, int count)
        {
            return collection.Count() >= count;
        }

        /// <summary>
        /// Checks if collection (IEnumerable) has more items than given number.
        /// </summary>        
        /// <param name="count">Items count.</param>
        /// <returns>Boolean value indicating if collection has more items than given number.</returns>
        public static bool HasMoreItemsThan<T>(this IEnumerable<T> collection, int count)
        {
            return collection.Count() > count;
        }
    }
}
