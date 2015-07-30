using System;
using Shouldly;
using Xunit;

namespace Conditions.Tests
{
    public class DateTimeExtensionsTests
    {
        [Fact]
        public void IsGreaterThan_GivenGreaterDateTime_ReturnsFalse()
        {
            var currentDateTime = DateTime.Now;

            currentDateTime.IsGreaterThan(currentDateTime.AddSeconds(1)).ShouldBe(false);
            currentDateTime.IsGreaterThan(currentDateTime.AddMinutes(1)).ShouldBe(false);
            currentDateTime.IsGreaterThan(currentDateTime.AddHours(1)).ShouldBe(false);
        }

        [Fact]
        public void IsGreaterThan_GivenLowerDateTime_ReturnsTrue()
        {
            var currentDateTime = DateTime.Now;

            currentDateTime.IsGreaterThan(currentDateTime.AddSeconds(-1)).ShouldBe(true);
            currentDateTime.IsGreaterThan(currentDateTime.AddMinutes(-1)).ShouldBe(true);
            currentDateTime.IsGreaterThan(currentDateTime.AddHours(-1)).ShouldBe(true);
        }

        [Fact]
        public void IsGreaterThan_GivenTheSameDateTime_ReturnsFalse()
        {
            var currentDateTime = DateTime.Now;

            currentDateTime.IsGreaterThan(currentDateTime).ShouldBe(false);
        }
    }
}
