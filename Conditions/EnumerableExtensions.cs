using System.Collections.Generic;
using System.Linq;

namespace Conditions
{
    public static class EnumerableExtensions
    {
        /// <summary>
        /// Checks if collection (IEnumerable) has only one item.
        /// </summary>        
        /// <returns>Boolean value whether collection has only one item.</returns>
        public static bool HasExactlyOneItem<T>(this IEnumerable<T> collection)
        {
            return collection.Count() == 1;
        }

        /// <summary>
        /// Checks if collection (IEnumerable) has more than one item.
        /// </summary>        
        /// <returns>Boolean value whether collection has more than one item.</returns>
        public static bool HasMoreThanOneItem<T>(this IEnumerable<T> collection)
        {
            return collection.Count() > 1;
        }

        /// <summary>
        /// Checks if collection (IEnumerable) has at least one item.
        /// </summary>        
        /// <returns>Boolean value whether collection has at least one item.</returns>
        public static bool HasAtLeastOneItem<T>(this IEnumerable<T> collection)
        {
            return collection.Count() >= 1;
        }

        /// <summary>
        /// Checks if collection (IEnumerable) has given number of items.
        /// </summary>        
        /// <param name="count">Items count.</param>
        /// <returns>Boolean value whether collection has given number of items.</returns>
        public static bool HasItemsCount<T>(this IEnumerable<T> collection, int count)
        {
            return collection.Count().Equals(count);
        }
    }
}
