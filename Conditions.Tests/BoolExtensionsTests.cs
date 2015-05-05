using Xunit;

namespace Conditions.Tests
{
    public class BoolExtensionsTests
    {
        [Fact]
        public void IsTrue_TrueValue_ReturnsTrue()
        {
            var trueValue = true;

            Assert.True(trueValue.IsTrue());
        }

        [Fact]
        public void IsTrue_FalseValue_ReturnsFalse()
        {
            var trueValue = false;

            Assert.False(trueValue.IsTrue());
        }

        [Fact]
        public void IsFalse_TrueValue_ReturnsFalse()
        {
            var trueValue = true;

            Assert.False(trueValue.IsFalse());
        }

        [Fact]
        public void IsFalse_FalseValue_ReturnsTrue()
        {
            var trueValue = false;

            Assert.True(trueValue.IsFalse());
        }
    }
}
