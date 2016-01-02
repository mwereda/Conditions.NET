using Shouldly;
using Xunit;

namespace Conditions.Tests
{
    public class NumericAndExtensionsTests
    {
        [Theory]
        [InlineData(4, true)]
        [InlineData(3, false)]
        [InlineData(2, false)]
        public void IsGreaterThan_AndObjectWithTrueResult_ReturnsExpectedResult(int givenValue, bool expectedResult)
        {
            var andCondition = new And<int>(givenValue, true);
            var result = andCondition.IsGreaterThan(3);

            result.Result.ShouldBe(expectedResult);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(3)]
        [InlineData(2)]
        public void IsGreaterThan_AndObjectWithFalseResult_ReturnsExpectedResult(int givenValue)
        {
            var andCondition = new And<int>(givenValue, false);
            var result = andCondition.IsGreaterThan(3);

            result.Result.ShouldBe(false);
        }

        [Theory]
        [InlineData(4, true)]
        [InlineData(3, true)]
        [InlineData(2, false)]
        public void IsGreaterOrEqual_AndObjectWithTrueResult_ReturnsExpectedResult(int givenValue, bool expectedResult)
        {
            var andCondition = new And<int>(givenValue, true);
            var result = andCondition.IsGreaterOrEqual(3);

            result.Result.ShouldBe(expectedResult);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(3)]
        [InlineData(2)]
        public void IsGreaterOrEqual_AndObjectWithFalseResult_ReturnsExpectedResult(int givenValue)
        {
            var andCondition = new And<int>(givenValue, false);
            var result = andCondition.IsGreaterOrEqual(3);

            result.Result.ShouldBe(false);
        }

        [Theory]
        [InlineData(4, false)]
        [InlineData(3, false)]
        [InlineData(2, true)]
        public void IsLowerThan_AndObjectWithTrueResult_ReturnsExpectedResult(int givenValue, bool expectedResult)
        {
            var andCondition = new And<int>(givenValue, true);
            var result = andCondition.IsLowerThan(3);

            result.Result.ShouldBe(expectedResult);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(3)]
        [InlineData(2)]
        public void IsLowerThan_AndObjectWithFalseResult_ReturnsExpectedResult(int givenValue)
        {
            var andCondition = new And<int>(givenValue, false);
            var result = andCondition.IsLowerThan(3);

            result.Result.ShouldBe(false);
        }

        [Theory]
        [InlineData(4, false)]
        [InlineData(3, true)]
        [InlineData(2, true)]
        public void IsLowerOrEqual_AndObjectWithTrueResult_ReturnsExpectedResult(int givenValue, bool expectedResult)
        {
            var andCondition = new And<int>(givenValue, true);
            var result = andCondition.IsLowerOrEqual(3);

            result.Result.ShouldBe(expectedResult);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(3)]
        [InlineData(2)]
        public void IsLowerOrEqual_AndObjectWithFalseResult_ReturnsExpectedResult(int givenValue)
        {
            var andCondition = new And<int>(givenValue, false);
            var result = andCondition.IsLowerOrEqual(3);

            result.Result.ShouldBe(false);
        }

        [Theory]
        [InlineData(4, true)]
        [InlineData(3, true)]
        [InlineData(2, false)]
        public void IsBetween_AndObjectWithTrueResult_ReturnsExpectedResult(int givenValue, bool expectedResult)
        {
            var andCondition = new And<int>(givenValue, true);
            var result = andCondition.IsBetween(3, 5);

            result.Result.ShouldBe(expectedResult);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(3)]
        [InlineData(2)]
        public void IsBetween_AndObjectWithFalseResult_ReturnsExpectedResult(int givenValue)
        {
            var andCondition = new And<int>(givenValue, false);
            var result = andCondition.IsBetween(3, 5);

            result.Result.ShouldBe(false);
        }

        [Theory]
        [InlineData(4, true)]
        [InlineData(3, true)]
        [InlineData(-2, false)]
        [InlineData(0, false)]
        public void IsPositive_AndObjectWithTrueResult_ReturnsExpectedResult(int givenValue, bool expectedResult)
        {
            var andCondition = new And<int>(givenValue, true);
            var result = andCondition.IsPositive();

            result.Result.ShouldBe(expectedResult);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(3)]
        [InlineData(-2)]
        [InlineData(0)]
        public void IsPositive_AndObjectWithFalseResult_ReturnsExpectedResult(int givenValue)
        {
            var andCondition = new And<int>(givenValue, false);
            var result = andCondition.IsPositive();

            result.Result.ShouldBe(false);
        }

        [Theory]
        [InlineData(4, false)]
        [InlineData(3, false)]
        [InlineData(-2, true)]
        [InlineData(0, false)]
        public void IsNegative_AndObjectWithTrueResult_ReturnsExpectedResult(int givenValue, bool expectedResult)
        {
            var andCondition = new And<int>(givenValue, true);
            var result = andCondition.IsNegative();

            result.Result.ShouldBe(expectedResult);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(3)]
        [InlineData(-2)]
        [InlineData(0)]
        public void IsNegative_AndObjectWithFalseResult_ReturnsExpectedResult(int givenValue)
        {
            var andCondition = new And<int>(givenValue, false);
            var result = andCondition.IsNegative();

            result.Result.ShouldBe(false);
        }
    }
}
