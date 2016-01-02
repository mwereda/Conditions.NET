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
        public static ConditionResult<IEnumerable<T>> IsEmpty<T>(this IEnumerable<T> collection)
        {
            return ConditionResult<IEnumerable<T>>.Create(collection.Count() == 0, collection);
        }

        /// <summary>
        /// Checks if collection (IEnumerable) is null or empty.
        /// </summary>        
        /// <returns>Boolean value indicating if collection is null or empty.</returns>
        public static ConditionResult<IEnumerable<T>> IsNullOrEmpty<T>(this IEnumerable<T> collection)
        {
            return ConditionResult<IEnumerable<T>>.Create(collection == null || collection.IsEmpty(), collection);
        }

        /// <summary>
        /// Checks if collection (IEnumerable) is not null or empty.
        /// </summary>        
        /// <returns>Boolean value indicating if collection is not null or empty.</returns>
        public static ConditionResult<IEnumerable<T>> IsNotNullOrEmpty<T>(this IEnumerable<T> collection)
        {
            return ConditionResult<IEnumerable<T>>.Create(!collection.IsNullOrEmpty(), collection);
        }

        /// <summary>
        /// Checks if collection (IEnumerable) has only one item.
        /// </summary>        
        /// <returns>Boolean value indicating if collection has only one item.</returns>
        public static ConditionResult<IEnumerable<T>> HasExactlyOneItem<T>(this IEnumerable<T> collection)
        {
            return ConditionResult<IEnumerable<T>>.Create(collection.Count() == 1, collection);
        }

        /// <summary>
        /// Checks if collection (IEnumerable) has more than one item.
        /// </summary>        
        /// <returns>Boolean value indicating if collection has more than one item.</returns>
        public static ConditionResult<IEnumerable<T>> HasMoreThanOneItem<T>(this IEnumerable<T> collection)
        {
            return ConditionResult<IEnumerable<T>>.Create(collection.Count() > 1, collection);
        }

        /// <summary>
        /// Checks if collection (IEnumerable) has at least one item.
        /// </summary>        
        /// <returns>Boolean value indicating if collection has at least one item.</returns>
        public static ConditionResult<IEnumerable<T>> HasAtLeastOneItem<T>(this IEnumerable<T> collection)
        {
            return ConditionResult<IEnumerable<T>>.Create(collection.Count() >= 1, collection);
        }

        /// <summary>
        /// Checks if collection (IEnumerable) has given number of items.
        /// </summary>        
        /// <param name="count">Items count.</param>
        /// <returns>Boolean value indicating if collection has given number of items.</returns>
        public static ConditionResult<IEnumerable<T>> HasItemsCount<T>(this IEnumerable<T> collection, int count)
        {
            return ConditionResult<IEnumerable<T>>.Create(collection.Count().Equals(count), collection);
        }

        /// <summary>
        /// Checks if collection (IEnumerable) has at least given number of items.
        /// </summary>        
        /// <param name="count">Items count.</param>
        /// <returns>Boolean value indicating if collection has at least given number of items.</returns>
        public static ConditionResult<IEnumerable<T>> HasItemsCountAtLeast<T>(this IEnumerable<T> collection, int count)
        {
            return ConditionResult<IEnumerable<T>>.Create(collection.Count() >= count, collection);
        }

        /// <summary>
        /// Checks if collection (IEnumerable) has more items than given number.
        /// </summary>        
        /// <param name="count">Items count.</param>
        /// <returns>Boolean value indicating if collection has more items than given number.</returns>
        public static ConditionResult<IEnumerable<T>> HasMoreItemsThan<T>(this IEnumerable<T> collection, int count)
        {
            return ConditionResult<IEnumerable<T>>.Create(collection.Count() > count, collection);
        }
    }
}
