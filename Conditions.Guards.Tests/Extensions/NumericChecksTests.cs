using System;
using Xunit;

namespace Conditions.Guards.Tests.Extensions
{
    public class NumericChecksTests
    {
        [Theory]
        [InlineData(31)]
        [InlineData(10)]
        public void IsGreaterThan_IntValueIsLowerOrEqualGivenValue_ThrowsArgumentException(int givenValue)
        {
            const int value = 10;

            Assert.Throws<ArgumentException>(() => Check.If(value).IsGreaterThan(givenValue));
        }

        [Theory]
        [InlineData(12.20)]
        [InlineData(11.99)]
        [InlineData(11.01)]
        public void IsGreaterThan_DecimalValueIsLowerOrEqualGivenValue_ThrowsArgumentException(decimal givenValue)
        {
            const decimal value = 11m;

            Assert.Throws<ArgumentException>(() => Check.If(value).IsGreaterThan(givenValue));
        }

        [Fact]
        public void IsGreaterOrEqual_IntValueIsLower_ThrowsArgumentException()
        {
            const int value = 10;
            const int minimalValue = 12;

            Assert.Throws<ArgumentException>(() => Check.If(value).IsGreaterOrEqual(minimalValue));
        }

        [Fact]
        public void IsGreaterOrEqual_DecimalValueIsLower_ThrowsArgumentException()
        {
            const decimal value = 100m;
            const decimal minimalValue = 100.01m;

            Assert.Throws<ArgumentException>(() => Check.If(value).IsGreaterOrEqual(minimalValue));
        }

        [Theory]
        [InlineData(10)]
        [InlineData(9)]
        public void IsLowerThan_IntHigherOrEqual_ThrowsArgumentException(int givenValue)
        {
            const int value = 10;

            Assert.Throws<ArgumentException>(() => Check.If(value).IsLowerThan(givenValue));
        }

        [Theory]
        [InlineData(10.0)]
        [InlineData(9.5)]
        public void IsLowerThan_DecimalHigherOrEqual_ThrowsArgumentException(decimal givenValue)
        {
            const decimal value = 10.0m;

            Assert.Throws<ArgumentException>(() => Check.If(value).IsLowerThan(givenValue));
        }

        [Fact]
        public void IsLowerOrEqual_IntValueIsGreater_ThrowsArgumentException()
        {
            const int value = 12;
            const int maximalValue = 10;

            Assert.Throws<ArgumentException>(() => Check.If(value).IsLowerOrEqual(maximalValue));
        }

        [Fact]
        public void IsLowerOrEqual_DecimalValueIsGreater_ThrowsArgumentException()
        {
            const decimal value = 100.02m;
            const decimal maximalValue = 100.01m;

            Assert.Throws<ArgumentException>(() => Check.If(value).IsLowerOrEqual(maximalValue));
        }

        [Fact]
        public void IsBetween_IntNotInRange_ThrowsArgumentException()
        {
            const int value = 10;
            const int minimalValue = 11;
            const int maximalValue = 29;

            Assert.Throws<ArgumentException>(() => Check.If(value).IsBetween(minimalValue, maximalValue));
        }

        [Fact]
        public void IsBetween_DecimalNotInRange_ThrowsArgumentException()
        {
            const decimal value = 10.1m;
            const decimal minimalValue = 10.11m;
            const decimal maximalValue = 29m;

            Assert.Throws<ArgumentException>(() => Check.If(value).IsBetween(minimalValue, maximalValue));
        }
    }
}
