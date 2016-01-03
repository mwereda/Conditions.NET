using Shouldly;
using Xunit;

namespace Conditions.Tests
{
    public class OrTests
    {
        [Fact]
        public void CalculateResult_ExternalResultIsTrueAndCurrentResultIsTrue_ReturnsTrue()
        {
            var or = new Or<int>(2, true);

            or.CalculateResult(true).ShouldBe(true);
        }

        [Fact]
        public void CalculateResult_ExternalResultIsFalseAndCurrentResultIsTrue_ReturnsTrue()
        {
            var or = new Or<int>(2, true);

            or.CalculateResult(false).ShouldBe(true);
        }

        [Fact]
        public void CalculateResult_ExternalResultIsFalseAndCurrentResultIsFalse_ReturnsFalse()
        {
            var or = new Or<int>(2, false);

            or.CalculateResult(false).ShouldBe(false);
        }

        [Fact]
        public void CalculateResult_ExternalResultIsTrueAndCurrentResultIsFalse_ReturnsTrue()
        {
            var or = new Or<int>(2, false);

            or.CalculateResult(true).ShouldBe(true);
        }
    }
}
