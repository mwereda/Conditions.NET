using System;

// ReSharper disable once CheckNamespace
namespace Conditions.Guards
{
	public static class DateTimeChecks
	{
		/// <summary>
		/// Guards against date time that's lower or equal reference date time.
		/// </summary>
		/// <param name="referenceDateTime">Reference date time.</param>
		public static void IsGreaterThan(this If<DateTime> ifObject, DateTime referenceDateTime)
		{
			if (!ifObject.Value.IsGreaterThan(referenceDateTime))
			{
				throw new ArgumentException(string.Format("DateTime should be greater than {0}", referenceDateTime), ifObject.ParamName);
			}
		}
	}
}
