using Shouldly;
using Xunit;

namespace Conditions.Tests
{
    public class BoolExtensionsTests
    {
        [Fact]
        public void IsTrue_TrueValue_ReturnsTrue()
        {
            var trueValue = true;

            trueValue.IsTrue().ShouldBe(true);
        }

        [Fact]
        public void IsTrue_FalseValue_ReturnsFalse()
        {
            var trueValue = false;

			trueValue.IsTrue().ShouldBe(false);
        }

        [Fact]
        public void IsFalse_TrueValue_ReturnsFalse()
        {
            var trueValue = true;

			trueValue.IsFalse().ShouldBe(false);
        }

        [Fact]
        public void IsFalse_FalseValue_ReturnsTrue()
        {
            var trueValue = false;

			trueValue.IsFalse().ShouldBe(true);
        }
    }
}
