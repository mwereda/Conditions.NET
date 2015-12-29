using Shouldly;

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
            value.IsGreaterThan(givenValue).Result.ShouldBe(true);
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(23, 31)]
        [InlineData(23, 24)]
        public void IsGreaterThan_IntValueLowerThanGivenValue_ReturnsFalse(int value, int givenValue)
        {
            value.IsGreaterThan(givenValue).Result.ShouldBe(false);
        }

        [Theory]
        [InlineData(2, 1)]
        [InlineData(23, 1)]
        [InlineData(23, 22)]
        public void IsGreaterOrEqual_IntValueGreaterThanGivenValue_ReturnsTrue(int value, int givenValue)
        {
            value.IsGreaterOrEqual(givenValue).Result.ShouldBe(true);
        }

        [Theory]
        [InlineData(2, 21)]
        [InlineData(23, 31)]
        [InlineData(23, 24)]
        public void IsGreaterOrEqual_IntValueLowerThanGivenValue_ReturnsFalse(int value, int givenValue)
        {
            value.IsGreaterOrEqual(givenValue).Result.ShouldBe(false);
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(23, 23)]
        [InlineData(233, 233)]
        public void IsGreaterOrEqual_IntValueEqualsGivenValue_ReturnsTrue(int value, int givenValue)
        {
            value.IsGreaterOrEqual(givenValue).Result.ShouldBe(true);
        }

        [Theory]
        [InlineData(2.12, 1)]
        [InlineData(23.1, 1)]
        [InlineData(23.3, 22.3)]
        [InlineData(23.3, 23.29)]
        public void IsGreaterThan_DecimalValueGreaterThanGivenValue_ReturnsTrue(decimal value, decimal givenValue)
        {
            value.IsGreaterThan(givenValue).Result.ShouldBe(true);
        }

        [Theory]
        [InlineData(2.0, 2.0)]
        [InlineData(23.4, 31.34)]
        [InlineData(23.2, 24.2)]
        public void IsGreaterThan_DecimalValueLowerThanGivenValue_ReturnsFalse(decimal value, decimal givenValue)
        {
            value.IsGreaterThan(givenValue).Result.ShouldBe(false);
        }

        [Theory]
        [InlineData(2.2, 1.01)]
        [InlineData(23.2, 1.2)]
        [InlineData(23.2, 22.2)]
        public void IsGreaterOrEqual_DecimalValueGreaterThanGivenValue_ReturnsTrue(decimal value, decimal givenValue)
        {
            value.IsGreaterOrEqual(givenValue).Result.ShouldBe(true);
        }

        [Theory]
        [InlineData(2.2, 21.2)]
        [InlineData(23.4, 31.1)]
        [InlineData(23.3, 24.3)]
        public void IsGreaterOrEqual_DecimalValueLowerThanGivenValue_ReturnsFalse(decimal value, decimal givenValue)
        {
            value.IsGreaterOrEqual(givenValue).Result.ShouldBe(false);
        }

        [Theory]
        [InlineData(2.01, 2.01)]
        [InlineData(23.9, 23.9)]
        [InlineData(2.33, 2.33)]
        public void IsGreaterOrEqual_DecimalValueEqualsGivenValue_ReturnsTrue(decimal value, decimal givenValue)
        {
            value.IsGreaterOrEqual(givenValue).Result.ShouldBe(true);
        }

        [Theory]
        [InlineData(1, 2)]
        [InlineData(1, 23)]
        [InlineData(22, 23)]
        public void IsLowerThan_IntValueLowerThanGivenValue_ReturnsTrue(int value, int givenValue)
        {
            value.IsLowerThan(givenValue).Result.ShouldBe(true);
        }

        [Theory]
        [InlineData(3, 2)]
        [InlineData(31, 23)]
        [InlineData(24, 23)]
        public void IsLowerOrEqual_IntValueGreaterThanGivenValue_ReturnsFalse(int value, int givenValue)
        {
            value.IsLowerOrEqual(givenValue).Result.ShouldBe(false);
        }

        [Theory]
        [InlineData(2, 2)]
        [InlineData(23, 23)]
        [InlineData(233, 233)]
        public void IsLowerOrEqual_IntValueEqualsGivenValue_ReturnsTrue(int value, int givenValue)
        {
            value.IsLowerOrEqual(givenValue).Result.ShouldBe(true);
        }

        [Theory]
        [InlineData(2, 2, 3)]
        [InlineData(12, 2, 23)]
        [InlineData(12, 2, 12)]
        [InlineData(20, 2, 300)]
        public void IsBetween_ValueBetweenGivenRange_ReturnsTrue(int value, int minValue, int maxValue)
        {
            value.IsBetween(minValue, maxValue).Result.ShouldBe(true);
        }

        [Theory]
        [InlineData(23, 2, 3)]
        [InlineData(12, 13, 23)]
        public void IsBetween_ValueIsNotBetweenGivenRange_ReturnsFalse(int value, int minValue, int maxValue)
        {
            value.IsBetween(minValue, maxValue).Result.ShouldBe(false);
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
            value.IsBetween(minValue, maxValue).Result.ShouldBe(true);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(21)]
        [InlineData(112)]
        [InlineData(331)]
        public void IsPositive_GivenPositiveInteger_ReturnsTrue(int value)
        {
            value.IsPositive().Result.ShouldBe(true);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-21)]
        [InlineData(-2)]
        [InlineData(-331)]
        [InlineData(0)]
        public void IsPositive_GivenNegativeOrZeroInteger_ReturnsFalse(int value)
        {
            value.IsPositive().Result.ShouldBe(false);
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(0.1)]
        [InlineData(2.43)]        
        public void IsPositive_GivenPositiveDouble_ReturnsTrue(double value)
        {
            value.IsPositive().Result.ShouldBe(true);
        }

        [Theory]
        [InlineData(-1.1)]
        [InlineData(-21.2)]
        [InlineData(-0.1)]
        [InlineData(-331.2)]
        [InlineData(0.0)]
        public void IsPositive_GivenNegativeOrZeroDouble_ReturnsFalse(double value)
        {
            value.IsPositive().Result.ShouldBe(false);
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(0.1)]
        [InlineData(2.43)]
        public void IsPositive_GivenPositiveDecimal_ReturnsTrue(decimal value)
        {
            value.IsPositive().Result.ShouldBe(true);
        }

        [Theory]
        [InlineData(-1.1)]
        [InlineData(-21.2)]
        [InlineData(-0.1)]
        [InlineData(-331.2)]
        [InlineData(0.0)]
        public void IsPositive_GivenNegativeOrZeroDecimal_ReturnsFalse(decimal value)
        {
            value.IsPositive().Result.ShouldBe(false);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(21)]
        [InlineData(112)]
        [InlineData(331)]
        [InlineData(0)]
        public void IsNegative_GivenPositiveOrZeroInteger_ReturnsFalse(int value)
        {
            value.IsNegative().Result.ShouldBe(false);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-21)]
        [InlineData(-2)]
        [InlineData(-331)]
        public void IsNegative_GivenNegativeInteger_ReturnsTrue(int value)
        {
            value.IsNegative().Result.ShouldBe(true);
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(0.1)]
        [InlineData(2.43)]
        [InlineData(0.0)]
        public void IsNegative_GivenPositiveOrZeroDouble_ReturnsFalse(double value)
        {
            value.IsNegative().Result.ShouldBe(false);
        }

        [Theory]
        [InlineData(-1.1)]
        [InlineData(-21.2)]
        [InlineData(-0.1)]
        [InlineData(-331.2)]
        public void IsNegative_GivenNegativeOrZeroDouble_ReturnsTrue(double value)
        {
            value.IsNegative().Result.ShouldBe(true);
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(0.1)]
        [InlineData(2.43)]
        [InlineData(0.0)]
        public void IsNegative_GivenPositiveOrZeroDecimal_ReturnsFalse(decimal value)
        {
            value.IsNegative().Result.ShouldBe(false);
        }

        [Theory]
        [InlineData(-1.1)]
        [InlineData(-21.2)]
        [InlineData(-0.1)]
        [InlineData(-331.2)]
        public void IsNegative_GivenNegative_ReturnsTrue(decimal value)
        {
            value.IsNegative().Result.ShouldBe(true);
        }
    }
}
