using System;

namespace Conditions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Checks if date time is greater than reference date time.
        /// </summary>        
        /// <param name="referenceDateTime">Reference date time.</param>
        /// <returns>Boolean value indicating if date time is greater than reference date time.</returns>
        public static bool IsGreaterThan(this DateTime dateTime, DateTime referenceDateTime)
        {
            return dateTime > referenceDateTime;
        }
    }
}
