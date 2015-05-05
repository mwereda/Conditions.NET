﻿using Xunit;

namespace Conditions.Tests
{
    public class NumericExtensionsTests
    {
        [Theory]
        [InlineData(2, 1)]
        [InlineData(23, 1)]
        [InlineData(23, 22)]
        public void IsGreaterThan_IntValueGreaterThanGivenValue_ReturnsTrue(int value, int givenValue)
        {
            Assert.True(value.IsGreaterThan(givenValue));
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(23, 31)]
        [InlineData(23, 24)]
        public void IsGreaterThan_IntValueLowerThanGivenValue_ReturnsFalse(int value, int givenValue)
        {
            Assert.False(value.IsGreaterThan(givenValue));
        }

        [Theory]
        [InlineData(2, 1)]
        [InlineData(23, 1)]
        [InlineData(23, 22)]
        public void IsGreaterOrEqual_IntValueGreaterThanGivenValue_ReturnsTrue(int value, int givenValue)
        {
            Assert.True(value.IsGreaterOrEqual(givenValue));
        }

        [Theory]
        [InlineData(2, 21)]
        [InlineData(23, 31)]
        [InlineData(23, 24)]
        public void IsGreaterOrEqual_IntValueLowerThanGivenValue_ReturnsFalse(int value, int givenValue)
        {
            Assert.False(value.IsGreaterOrEqual(givenValue));
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(23, 23)]
        [InlineData(233, 233)]
        public void IsGreaterOrEqual_IntValueEqualsGivenValue_ReturnsTrue(int value, int givenValue)
        {
            Assert.True(value.IsGreaterOrEqual(givenValue));
        }

        [Theory]
        [InlineData(2.12, 1)]
        [InlineData(23.1, 1)]
        [InlineData(23.3, 22.3)]
        [InlineData(23.3, 23.29)]
        public void IsGreaterThan_DecimalValueGreaterThanGivenValue_ReturnsTrue(decimal value, decimal givenValue)
        {
            Assert.True(value.IsGreaterThan(givenValue));
        }

        [Theory]
        [InlineData(2.0, 2.0)]
        [InlineData(23.4, 31.34)]
        [InlineData(23.2, 24.2)]
        public void IsGreaterThan_DecimalValueLowerThanGivenValue_ReturnsFalse(decimal value, decimal givenValue)
        {
            Assert.False(value.IsGreaterThan(givenValue));
        }

        [Theory]
        [InlineData(2.2, 1.01)]
        [InlineData(23.2, 1.2)]
        [InlineData(23.2, 22.2)]
        public void IsGreaterOrEqual_DecimalValueGreaterThanGivenValue_ReturnsTrue(decimal value, decimal givenValue)
        {
            Assert.True(value.IsGreaterOrEqual(givenValue));
        }

        [Theory]
        [InlineData(2.2, 21.2)]
        [InlineData(23.4, 31.1)]
        [InlineData(23.3, 24.3)]
        public void IsGreaterOrEqual_DecimalValueLowerThanGivenValue_ReturnsFalse(decimal value, decimal givenValue)
        {
            Assert.False(value.IsGreaterOrEqual(givenValue));
        }

        [Theory]
        [InlineData(2.01, 2.01)]
        [InlineData(23.9, 23.9)]
        [InlineData(2.33, 2.33)]
        public void IsGreaterOrEqual_DecimalValueEqualsGivenValue_ReturnsTrue(decimal value, decimal givenValue)
        {
            Assert.True(value.IsGreaterOrEqual(givenValue));
        }
    }
}
