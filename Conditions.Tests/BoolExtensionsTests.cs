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

            trueValue.IsTrue().Result.ShouldBe(true);
        }

        [Fact]
        public void IsTrue_FalseValue_ReturnsFalse()
        {
            var trueValue = false;

            trueValue.IsTrue().Result.ShouldBe(false);
        }

        [Fact]
        public void IsFalse_TrueValue_ReturnsFalse()
        {
            var trueValue = true;

            trueValue.IsFalse().Result.ShouldBe(false);
        }

        [Fact]
        public void IsFalse_FalseValue_ReturnsTrue()
        {
            var trueValue = false;

            trueValue.IsFalse().Result.ShouldBe(true);
        }
    }
}
