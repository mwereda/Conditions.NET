using System;
using Shouldly;
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

            Should.Throw<ArgumentException>(() => Check.If(value).IsGreaterThan(givenValue));
        }

        [Theory]
        [InlineData(12.20)]
        [InlineData(11.99)]
        [InlineData(11.01)]
        public void IsGreaterThan_DecimalValueIsLowerOrEqualGivenValue_ThrowsArgumentException(decimal givenValue)
        {
            const decimal value = 11m;

            Should.Throw<ArgumentException>(() => Check.If(value).IsGreaterThan(givenValue));
        }

        [Theory]
        [InlineData(31)]
        [InlineData(10)]
        public void IsGreaterThan_IntValueIsLowerOrEqualGivenValueArgumentNullExceptionConfiguredObsolete_ThrowsArgumentNullException(int givenValue)
        {
            const int value = 10;

            Should.Throw<ArgumentNullException>(() => Check.AndThrowThisWhenFail<ArgumentNullException>().If(value).IsGreaterThan(givenValue));
        }

        [Theory]
        [InlineData(31)]
        [InlineData(10)]
        public void IsGreaterThan_IntValueIsLowerOrEqualGivenValueArgumentNullExceptionConfigured_ThrowsArgumentNullException(int givenValue)
        {
            const int value = 10;

            Should.Throw<ArgumentNullException>(() => Check.AndThrowThisWhenFails<ArgumentNullException>().If(value).IsGreaterThan(givenValue));
        }

        [Theory]
        [InlineData(12.20)]
        [InlineData(11.99)]
        [InlineData(11.01)]
        public void IsGreaterThan_DecimalValueIsLowerOrEqualGivenValueInvalidOperationExceptionConfiguredObsolete_ThrowsInvalidOperationException(decimal givenValue)
        {
            const decimal value = 11m;

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFail<InvalidOperationException>().If(value).IsGreaterThan(givenValue));
        }

        [Theory]
        [InlineData(12.20)]
        [InlineData(11.99)]
        [InlineData(11.01)]
        public void IsGreaterThan_DecimalValueIsLowerOrEqualGivenValueInvalidOperationExceptionConfigured_ThrowsInvalidOperationException(decimal givenValue)
        {
            const decimal value = 11m;

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFails<InvalidOperationException>().If(value).IsGreaterThan(givenValue));
        }

        [Theory]
        [InlineData(31)]
        [InlineData(10)]
        public void IsGreaterThan_IntValueIsLowerOrEqualGivenValueArgumentNullExceptionConfiguredWithFactoryObsolete_ThrowsArgumentNullException(int givenValue)
        {
            const int value = 10;

            Should.Throw<ArgumentNullException>(() => Check.AndThrowThisWhenFail(() => new ArgumentNullException()).If(value).IsGreaterThan(givenValue));
        }

        [Theory]
        [InlineData(31)]
        [InlineData(10)]
        public void IsGreaterThan_IntValueIsLowerOrEqualGivenValueArgumentNullExceptionConfiguredWithFactory_ThrowsArgumentNullException(int givenValue)
        {
            const int value = 10;

            Should.Throw<ArgumentNullException>(() => Check.AndThrowThisWhenFails(() => new ArgumentNullException()).If(value).IsGreaterThan(givenValue));
        }

        [Theory]
        [InlineData(12.20)]
        [InlineData(11.99)]
        [InlineData(11.01)]
        public void IsGreaterThan_DecimalValueIsLowerOrEqualGivenValueInvalidOperationExceptionConfiguredWithFactoryObsolete_ThrowsInvalidOperationException(decimal givenValue)
        {
            const decimal value = 11m;

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFail(() => new InvalidOperationException()).If(value).IsGreaterThan(givenValue));
        }

        [Theory]
        [InlineData(12.20)]
        [InlineData(11.99)]
        [InlineData(11.01)]
        public void IsGreaterThan_DecimalValueIsLowerOrEqualGivenValueInvalidOperationExceptionConfiguredWithFactory_ThrowsInvalidOperationException(decimal givenValue)
        {
            const decimal value = 11m;

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFails(() => new InvalidOperationException()).If(value).IsGreaterThan(givenValue));
        }

        [Fact]
        public void IsGreaterOrEqual_IntValueIsLower_ThrowsArgumentException()
        {
            const int value = 10;
            const int minimalValue = 12;

            Should.Throw<ArgumentException>(() => Check.If(value).IsGreaterOrEqual(minimalValue));
        }

        [Fact]
        public void IsGreaterOrEqual_DecimalValueIsLower_ThrowsArgumentException()
        {
            const decimal value = 100m;
            const decimal minimalValue = 100.01m;

            Should.Throw<ArgumentException>(() => Check.If(value).IsGreaterOrEqual(minimalValue));
        }

        [Fact]
        public void IsGreaterOrEqual_IntValueIsLowerNullReferenceExceptionConfiguredObsolete_ThrowsNullReferenceException()
        {
            const int value = 10;
            const int minimalValue = 12;

            Should.Throw<NullReferenceException>(() => Check.AndThrowThisWhenFail<NullReferenceException>().If(value).IsGreaterOrEqual(minimalValue));
        }

        [Fact]
        public void IsGreaterOrEqual_IntValueIsLowerNullReferenceExceptionConfigured_ThrowsNullReferenceException()
        {
            const int value = 10;
            const int minimalValue = 12;

            Should.Throw<NullReferenceException>(() => Check.AndThrowThisWhenFails<NullReferenceException>().If(value).IsGreaterOrEqual(minimalValue));
        }

        [Fact]
        public void IsGreaterOrEqual_DecimalValueIsLowerDummyExceptionConfiguredObsolete_ThrowsDummyException()
        {
            const decimal value = 100m;
            const decimal minimalValue = 100.01m;

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFail<DummyException>().If(value).IsGreaterOrEqual(minimalValue));
        }

        [Fact]
        public void IsGreaterOrEqual_DecimalValueIsLowerDummyExceptionConfigured_ThrowsDummyException()
        {
            const decimal value = 100m;
            const decimal minimalValue = 100.01m;

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails<DummyException>().If(value).IsGreaterOrEqual(minimalValue));
        }

        [Fact]
        public void IsGreaterOrEqual_IntValueIsLowerNullReferenceExceptionConfiguredWithFactoryObsolete_ThrowsNullReferenceException()
        {
            const int value = 10;
            const int minimalValue = 12;

            Should.Throw<NullReferenceException>(() => Check.AndThrowThisWhenFail(() => new NullReferenceException()).If(value).IsGreaterOrEqual(minimalValue));
        }

        [Fact]
        public void IsGreaterOrEqual_IntValueIsLowerNullReferenceExceptionConfiguredWithFactory_ThrowsNullReferenceException()
        {
            const int value = 10;
            const int minimalValue = 12;

            Should.Throw<NullReferenceException>(() => Check.AndThrowThisWhenFails(() => new NullReferenceException()).If(value).IsGreaterOrEqual(minimalValue));
        }

        [Fact]
        public void IsGreaterOrEqual_DecimalValueIsLowerDummyExceptionConfiguredWithFactoryObsolete_ThrowsDummyException()
        {
            const decimal value = 100m;
            const decimal minimalValue = 100.01m;

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFail(() => new DummyException()).If(value).IsGreaterOrEqual(minimalValue));
        }

        [Fact]
        public void IsGreaterOrEqual_DecimalValueIsLowerDummyExceptionConfiguredWithFactory_ThrowsDummyException()
        {
            const decimal value = 100m;
            const decimal minimalValue = 100.01m;

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails(() => new DummyException()).If(value).IsGreaterOrEqual(minimalValue));
        }

        [Theory]
        [InlineData(10)]
        [InlineData(9)]
        public void IsLowerThan_IntHigherOrEqual_ThrowsArgumentException(int givenValue)
        {
            const int value = 10;

            Should.Throw<ArgumentException>(() => Check.If(value).IsLowerThan(givenValue));
        }

        [Theory]
        [InlineData(10.0)]
        [InlineData(9.5)]
        public void IsLowerThan_DecimalHigherOrEqual_ThrowsArgumentException(decimal givenValue)
        {
            const decimal value = 10.0m;

            Should.Throw<ArgumentException>(() => Check.If(value).IsLowerThan(givenValue));
        }

        [Theory]
        [InlineData(10)]
        [InlineData(9)]
        public void IsLowerThan_IntHigherOrEqualArgumentNullExceptionConfiguredObsolete_ThrowsArgumentNullException(int givenValue)
        {
            const int value = 10;

            Should.Throw<ArgumentNullException>(() => Check.AndThrowThisWhenFail<ArgumentNullException>().If(value).IsLowerThan(givenValue));
        }

        [Theory]
        [InlineData(10)]
        [InlineData(9)]
        public void IsLowerThan_IntHigherOrEqualArgumentNullExceptionConfigured_ThrowsArgumentNullException(int givenValue)
        {
            const int value = 10;

            Should.Throw<ArgumentNullException>(() => Check.AndThrowThisWhenFails<ArgumentNullException>().If(value).IsLowerThan(givenValue));
        }

        [Theory]
        [InlineData(10.0)]
        [InlineData(9.5)]
        public void IsLowerThan_DecimalHigherOrEqualDummyExceptionConfiguredObsolete_ThrowsDummyException(decimal givenValue)
        {
            const decimal value = 10.0m;

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFail<DummyException>().If(value).IsLowerThan(givenValue));
        }

        [Theory]
        [InlineData(10.0)]
        [InlineData(9.5)]
        public void IsLowerThan_DecimalHigherOrEqualDummyExceptionConfigured_ThrowsDummyException(decimal givenValue)
        {
            const decimal value = 10.0m;

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails<DummyException>().If(value).IsLowerThan(givenValue));
        }

        [Theory]
        [InlineData(10)]
        [InlineData(9)]
        public void IsLowerThan_IntHigherOrEqualArgumentNullExceptionConfiguredWithFactoryObsolete_ThrowsArgumentNullException(int givenValue)
        {
            const int value = 10;

            Should.Throw<ArgumentNullException>(() => Check.AndThrowThisWhenFail(() => new ArgumentNullException()).If(value).IsLowerThan(givenValue));
        }

        [Theory]
        [InlineData(10)]
        [InlineData(9)]
        public void IsLowerThan_IntHigherOrEqualArgumentNullExceptionConfiguredWithFactory_ThrowsArgumentNullException(int givenValue)
        {
            const int value = 10;

            Should.Throw<ArgumentNullException>(() => Check.AndThrowThisWhenFails(() => new ArgumentNullException()).If(value).IsLowerThan(givenValue));
        }

        [Theory]
        [InlineData(10.0)]
        [InlineData(9.5)]
        public void IsLowerThan_DecimalHigherOrEqualDummyExceptionConfiguredWithFactoryObsolete_ThrowsDummyException(decimal givenValue)
        {
            const decimal value = 10.0m;

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFail(() => new DummyException()).If(value).IsLowerThan(givenValue));
        }

        [Theory]
        [InlineData(10.0)]
        [InlineData(9.5)]
        public void IsLowerThan_DecimalHigherOrEqualDummyExceptionConfiguredWithFactory_ThrowsDummyException(decimal givenValue)
        {
            const decimal value = 10.0m;

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails(() => new DummyException()).If(value).IsLowerThan(givenValue));
        }

        [Fact]
        public void IsLowerOrEqual_IntValueIsGreater_ThrowsArgumentException()
        {
            const int value = 12;
            const int maximalValue = 10;

            Should.Throw<ArgumentException>(() => Check.If(value).IsLowerOrEqual(maximalValue));
        }

        [Fact]
        public void IsLowerOrEqual_DecimalValueIsGreater_ThrowsArgumentException()
        {
            const decimal value = 100.02m;
            const decimal maximalValue = 100.01m;

            Should.Throw<ArgumentException>(() => Check.If(value).IsLowerOrEqual(maximalValue));
        }

        [Fact]
        public void IsLowerOrEqual_IntValueIsGreaterInvalidOperationExceptionConfiguredObsolete_ThrowsInvalidOperationException()
        {
            const int value = 12;
            const int maximalValue = 10;

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFail<InvalidOperationException>().If(value).IsLowerOrEqual(maximalValue));
        }

        [Fact]
        public void IsLowerOrEqual_IntValueIsGreaterInvalidOperationExceptionConfigured_ThrowsInvalidOperationException()
        {
            const int value = 12;
            const int maximalValue = 10;

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFails<InvalidOperationException>().If(value).IsLowerOrEqual(maximalValue));
        }

        [Fact]
        public void IsLowerOrEqual_DecimalValueIsGreaterArgumentNullExceptionConfiguredObsolete_ThrowsArgumentNullException()
        {
            const decimal value = 100.02m;
            const decimal maximalValue = 100.01m;

            Should.Throw<ArgumentNullException>(() => Check.AndThrowThisWhenFail<ArgumentNullException>().If(value).IsLowerOrEqual(maximalValue));
        }

        [Fact]
        public void IsLowerOrEqual_DecimalValueIsGreaterArgumentNullExceptionConfigured_ThrowsArgumentNullException()
        {
            const decimal value = 100.02m;
            const decimal maximalValue = 100.01m;

            Should.Throw<ArgumentNullException>(() => Check.AndThrowThisWhenFails<ArgumentNullException>().If(value).IsLowerOrEqual(maximalValue));
        }

        [Fact]
        public void IsLowerOrEqual_IntValueIsGreaterInvalidOperationExceptionConfiguredWithFactoryObsolete_ThrowsInvalidOperationException()
        {
            const int value = 12;
            const int maximalValue = 10;

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFail(() => new InvalidOperationException()).If(value).IsLowerOrEqual(maximalValue));
        }

        [Fact]
        public void IsLowerOrEqual_IntValueIsGreaterInvalidOperationExceptionConfiguredWithFactory_ThrowsInvalidOperationException()
        {
            const int value = 12;
            const int maximalValue = 10;

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFails(() => new InvalidOperationException()).If(value).IsLowerOrEqual(maximalValue));
        }

        [Fact]
        public void IsLowerOrEqual_DecimalValueIsGreaterArgumentNullExceptionConfiguredWithFactoryObsolete_ThrowsArgumentNullException()
        {
            const decimal value = 100.02m;
            const decimal maximalValue = 100.01m;

            Should.Throw<ArgumentNullException>(() => Check.AndThrowThisWhenFail(() => new ArgumentNullException()).If(value).IsLowerOrEqual(maximalValue));
        }

        [Fact]
        public void IsLowerOrEqual_DecimalValueIsGreaterArgumentNullExceptionConfiguredWithFactory_ThrowsArgumentNullException()
        {
            const decimal value = 100.02m;
            const decimal maximalValue = 100.01m;

            Should.Throw<ArgumentNullException>(() => Check.AndThrowThisWhenFails(() => new ArgumentNullException()).If(value).IsLowerOrEqual(maximalValue));
        }

        [Fact]
        public void IsBetween_IntNotInRange_ThrowsArgumentException()
        {
            const int value = 10;
            const int minimalValue = 11;
            const int maximalValue = 29;

            Should.Throw<ArgumentException>(() => Check.If(value).IsBetween(minimalValue, maximalValue));
        }

        [Fact]
        public void IsBetween_DecimalNotInRange_ThrowsArgumentException()
        {
            const decimal value = 10.1m;
            const decimal minimalValue = 10.11m;
            const decimal maximalValue = 29m;

            Should.Throw<ArgumentException>(() => Check.If(value).IsBetween(minimalValue, maximalValue));
        }

        [Fact]
        public void IsBetween_IntNotInRangeDummyExceptionConfiguredObsolete_ThrowsDummyException()
        {
            const int value = 10;
            const int minimalValue = 11;
            const int maximalValue = 29;

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFail<DummyException>().If(value).IsBetween(minimalValue, maximalValue));
        }

        [Fact]
        public void IsBetween_IntNotInRangeDummyExceptionConfigured_ThrowsDummyException()
        {
            const int value = 10;
            const int minimalValue = 11;
            const int maximalValue = 29;

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails<DummyException>().If(value).IsBetween(minimalValue, maximalValue));
        }

        [Fact]
        public void IsBetween_DecimalNotInRangeInvalidOperationExceptionConfiguredObsolete_ThrowsInvalidOperationException()
        {
            const decimal value = 10.1m;
            const decimal minimalValue = 10.11m;
            const decimal maximalValue = 29m;

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFail<InvalidOperationException>().If(value).IsBetween(minimalValue, maximalValue));
        }

        [Fact]
        public void IsBetween_DecimalNotInRangeInvalidOperationExceptionConfigured_ThrowsInvalidOperationException()
        {
            const decimal value = 10.1m;
            const decimal minimalValue = 10.11m;
            const decimal maximalValue = 29m;

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFails<InvalidOperationException>().If(value).IsBetween(minimalValue, maximalValue));
        }

        [Fact]
        public void IsBetween_IntNotInRangeDummyExceptionConfiguredWithFactoryObsolete_ThrowsDummyException()
        {
            const int value = 10;
            const int minimalValue = 11;
            const int maximalValue = 29;

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFail(() => new DummyException()).If(value).IsBetween(minimalValue, maximalValue));
        }

        [Fact]
        public void IsBetween_IntNotInRangeDummyExceptionConfiguredWithFactory_ThrowsDummyException()
        {
            const int value = 10;
            const int minimalValue = 11;
            const int maximalValue = 29;

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails(() => new DummyException()).If(value).IsBetween(minimalValue, maximalValue));
        }

        [Fact]
        public void IsBetween_DecimalNotInRangeInvalidOperationExceptionConfiguredWithFactoryObsolete_ThrowsInvalidOperationException()
        {
            const decimal value = 10.1m;
            const decimal minimalValue = 10.11m;
            const decimal maximalValue = 29m;

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFail(() => new InvalidOperationException()).If(value).IsBetween(minimalValue, maximalValue));
        }

        [Fact]
        public void IsBetween_DecimalNotInRangeInvalidOperationExceptionConfiguredWithFactory_ThrowsInvalidOperationException()
        {
            const decimal value = 10.1m;
            const decimal minimalValue = 10.11m;
            const decimal maximalValue = 29m;

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFails(() => new InvalidOperationException()).If(value).IsBetween(minimalValue, maximalValue));
        }
    }
}
