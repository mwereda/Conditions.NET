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

            or.CalculateResult(x => true).ShouldBe(true);
        }

        [Fact]
        public void CalculateResult_ExternalResultIsFalseAndCurrentResultIsTrue_ReturnsTrue()
        {
            var or = new Or<int>(2, true);

            or.CalculateResult(x => false).ShouldBe(true);
        }

        [Fact]
        public void CalculateResult_ExternalResultIsFalseAndCurrentResultIsFalse_ReturnsFalse()
        {
            var or = new Or<int>(2, false);

            or.CalculateResult(x => false).ShouldBe(false);
        }

        [Fact]
        public void CalculateResult_ExternalResultIsTrueAndCurrentResultIsFalse_ReturnsTrue()
        {
            var or = new Or<int>(2, false);

            or.CalculateResult(x => true).ShouldBe(true);
        }
    }
}
