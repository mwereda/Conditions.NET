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
    }
}
