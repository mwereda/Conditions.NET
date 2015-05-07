using Xunit;

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

        [Theory]
        [InlineData(1, 2)]
        [InlineData(1, 23)]
        [InlineData(22, 23)]
        public void IsLowerThan_IntValueLowerThanGivenValue_ReturnsTrue(int value, int givenValue)
        {
            Assert.True(value.IsLowerThan(givenValue));
        }

        [Theory]
        [InlineData(3, 2)]
        [InlineData(31, 23)]
        [InlineData(24, 23)]
        public void IsLowerOrEqual_IntValueGreaterThanGivenValue_ReturnsFalse(int value, int givenValue)
        {
            Assert.False(value.IsLowerOrEqual(givenValue));
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(23, 23)]
        [InlineData(233, 233)]
        public void IsLowerOrEqual_IntValueEqualsGivenValue_ReturnsTrue(int value, int givenValue)
        {
            Assert.True(value.IsLowerOrEqual(givenValue));
        }

        [Theory]
        [InlineData(2, 2, 3)]
        [InlineData(12, 2, 23)]
        [InlineData(12, 2, 12)]
        [InlineData(20, 2, 300)]
        public void IsBetween_ValueBetweenGivenRange_ReturnsTrue(int value, int minValue, int maxValue)
        {
            Assert.True(value.IsBetween(minValue, maxValue));
        }

        [Theory]
        [InlineData(23, 2, 3)]
        [InlineData(12, 13, 23)]
        public void IsBetween_ValueIsNotBetweenGivenRange_ReturnsFalse(int value, int minValue, int maxValue)
        {
            Assert.False(value.IsBetween(minValue, maxValue));
        }

        [Theory]
        [InlineData(2.0, 2.0, 3.0)]
        [InlineData(12.0, 2.4, 23.5)]
        [InlineData(12.5, 2.9, 12.5)]
        [InlineData(20.2, 2.0, 300.3)]
        [InlineData(2.71, 2.7, 3.0)]
        [InlineData(2.99, 2.0, 3.0)]
        public void IsBetween_DecimalValueBetweenGivenRange_ReturnsTrue(decimal value, decimal minValue, decimal maxValue)
        {
            Assert.True(value.IsBetween(minValue, maxValue));
        }
    }
}
