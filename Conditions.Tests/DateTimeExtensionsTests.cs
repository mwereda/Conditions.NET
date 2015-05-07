using System;
using Xunit;

namespace Conditions.Tests
{
    public class DateTimeExtensionsTests
    {
        [Fact]
        public void IsGreaterThan_GivenGreaterDateTime_ReturnsFalse()
        {
            var currentDateTime = DateTime.Now;

            Assert.False(currentDateTime.IsGreaterThan(currentDateTime.AddSeconds(1)));
            Assert.False(currentDateTime.IsGreaterThan(currentDateTime.AddMinutes(1)));
            Assert.False(currentDateTime.IsGreaterThan(currentDateTime.AddHours(1)));
        }

        [Fact]
        public void IsGreaterThan_GivenLowerDateTime_ReturnsTrue()
        {
            var currentDateTime = DateTime.Now;

            Assert.True(currentDateTime.IsGreaterThan(currentDateTime.AddSeconds(-1)));
            Assert.True(currentDateTime.IsGreaterThan(currentDateTime.AddMinutes(-1)));
            Assert.True(currentDateTime.IsGreaterThan(currentDateTime.AddHours(-1)));
        }

        [Fact]
        public void IsGreaterThan_GivenTheSameDateTime_ReturnsFalse()
        {
            var currentDateTime = DateTime.Now;

            Assert.False(currentDateTime.IsGreaterThan(currentDateTime));
        }
    }
}
