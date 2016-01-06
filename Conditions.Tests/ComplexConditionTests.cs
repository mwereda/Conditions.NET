using Shouldly;
using Xunit;

namespace Conditions.Tests
{
    public class ComplexConditionTests
    {
        [Theory]
        [InlineData(5, 14, true)]
        [InlineData(10, 12, true)]
        [InlineData(0, 23, true)]
        [InlineData(0, 10, false)]
        [InlineData(0, 11, false)]
        public void IntegerHigherThanGivenValueAndLowerOrHigherThanGivenValue_ReturnsExpectedResult(int lower, int higher, bool expectedResult)
        {
            int value = 11;

            var conditionResult = value.IsLowerThan(higher).And.IsGreaterThan(lower);

            conditionResult.Result.ShouldBe(expectedResult);
        }

        [Theory]
        [InlineData(5, 14, false)]
        [InlineData(10, 12, false)]
        [InlineData(23, 2, true)]
        [InlineData(0, 10, true)]
        [InlineData(0, 11, false)]
        public void IntegerHigherThanGivenValueOrLowerThanGivenValue_ReturnsExpectedResult(int lower, int higher, bool expectedResult)
        {
            int value = 11;

            var conditionResult = value.IsLowerThan(lower).Or.IsGreaterThan(higher);

            conditionResult.Result.ShouldBe(expectedResult);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(11)]
        [InlineData(99)]
        public void IntegerIsPositiveAndGreaterThanValueAndLowerThan100_ReturnsTrue(int givenValue)
        {
            var conditionResult = givenValue.IsPositive().And.IsGreaterThan(1).And.IsLowerThan(100);

            conditionResult.Result.ShouldBeTrue();
        }

        [Theory]
        [InlineData(-3)]
        [InlineData(0)]
        [InlineData(11)]
        [InlineData(999)]
        public void IntegerIsPositiveAndGreaterThanValueOrLowerThan100_ReturnsTrue(int givenValue)
        {
            var conditionResult = givenValue.IsPositive().And.IsGreaterThan(1).Or.IsLowerThan(100);

            conditionResult.Result.ShouldBeTrue();
        }
    }
}
