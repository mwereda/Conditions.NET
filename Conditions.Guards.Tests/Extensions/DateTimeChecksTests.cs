using System;
using Shouldly;
using Xunit;

namespace Conditions.Guards.Tests.Extensions
{
	public class DateTimeChecksTests
	{
		[Fact]
		public void IsGreaterThan_DateTimeIsLowerOrEqualReferenceDate_ThrowsArgumentException()
		{
			var currentDateTime = DateTime.Now;

			Should.Throw<ArgumentException>(() => Check.If(currentDateTime).IsGreaterThan(currentDateTime));
			Should.Throw<ArgumentException>(() => Check.If(currentDateTime).IsGreaterThan(currentDateTime.AddDays(1)));
			Should.Throw<ArgumentException>(() => Check.If(currentDateTime).IsGreaterThan(currentDateTime.AddMilliseconds(1)));
			Should.Throw<ArgumentException>(() => Check.If(currentDateTime).IsGreaterThan(currentDateTime.AddHours(1)));
			Should.Throw<ArgumentException>(() => Check.If(currentDateTime).IsGreaterThan(currentDateTime.AddMinutes(1)));
			Should.Throw<ArgumentException>(() => Check.If(currentDateTime).IsGreaterThan(currentDateTime.AddSeconds(1)));
		}
	}
}
