using Shouldly;
using Xunit;

namespace Conditions.Tests
{
    public class ObjectExtensionsTests
    {
        [Fact]
        public void IsNull_NullObject_ReturnsTrue()
        {
            DummyClass dummy = null;

            dummy.IsNull().ShouldBe(true);
        }

        [Fact]
        public void IsNull_NotNullObject_ReturnsFalse()
        {
            DummyClass dummy = new DummyClass();

            dummy.IsNull().ShouldBe(false);
        }

        [Fact]
        public void IsNotNull_NullObject_ReturnsFalse()
        {
            DummyClass dummy = null;

            dummy.IsNotNull().ShouldBe(false);
        }

        [Fact]
        public void IsNotNull_NotNullObject_ReturnsTrue()
        {
            DummyClass dummy = new DummyClass();

            dummy.IsNotNull().ShouldBe(true);
        }
    }
}
