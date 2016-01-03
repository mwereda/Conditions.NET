using Shouldly;
using Xunit;

namespace Conditions.Tests
{
    public class AndTests
    {
        [Fact]
        public void CalculateResult_ExternalResultIsTrueAndCurrentResultIsTrue_ReturnsTrue()
        {
            var and = new And<int>(2, true);

            and.CalculateResult(true).ShouldBe(true);
        }

        [Fact]
        public void CalculateResult_ExternalResultIsFalseAndCurrentResultIsTrue_ReturnsFalse()
        {
            var and = new And<int>(2, true);

            and.CalculateResult(false).ShouldBe(false);
        }

        [Fact]
        public void CalculateResult_ExternalResultIsFalseAndCurrentResultIsFalse_ReturnsFalse()
        {
            var and = new And<int>(2, false);

            and.CalculateResult(false).ShouldBe(false);
        }

        [Fact]
        public void CalculateResult_ExternalResultIsTrueAndCurrentResultIsFalse_ReturnsFalse()
        {
            var and = new And<int>(2, false);

            and.CalculateResult(true).ShouldBe(false);
        }
    }
}
