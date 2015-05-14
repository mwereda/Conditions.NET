using System;
using Xunit;

namespace Conditions.Guards.Tests.Extensions
{
	public class DateTimeChecksTests
	{
		[Fact]
		public void IsGreaterThan_DateTimeIsLowerOrEqualReferenceDate_ThrowsArgumentException()
		{
			var currentDateTime = DateTime.Now;

			Assert.Throws<ArgumentException>(() => Check.If(currentDateTime).IsGreaterThan(currentDateTime));
			Assert.Throws<ArgumentException>(() => Check.If(currentDateTime).IsGreaterThan(currentDateTime.AddDays(1)));
			Assert.Throws<ArgumentException>(() => Check.If(currentDateTime).IsGreaterThan(currentDateTime.AddMilliseconds(1)));
			Assert.Throws<ArgumentException>(() => Check.If(currentDateTime).IsGreaterThan(currentDateTime.AddHours(1)));
			Assert.Throws<ArgumentException>(() => Check.If(currentDateTime).IsGreaterThan(currentDateTime.AddMinutes(1)));
			Assert.Throws<ArgumentException>(() => Check.If(currentDateTime).IsGreaterThan(currentDateTime.AddSeconds(1)));
		}
	}
}
