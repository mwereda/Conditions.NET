using Xunit;

namespace Conditions.Tests
{
    public class ObjectExtensionsTests
    {
        [Fact]
        public void IsNull_NullObject_ReturnsTrue()
        {
            DummyClass dummy= null;
            
            Assert.True(dummy.IsNull());
        }

        [Fact]
        public void IsNull_NotNullObject_ReturnsFalse()
        {
            DummyClass dummy = new DummyClass();

            Assert.False(dummy.IsNull());
        }

        [Fact]
        public void IsNotNull_NullObject_ReturnsFalse()
        {
            DummyClass dummy = null;

            Assert.False(dummy.IsNotNull());
        }

        [Fact]
        public void IsNotNull_NotNullObject_ReturnsTrue()
        {
            DummyClass dummy = new DummyClass();

            Assert.True(dummy.IsNotNull());
        }

        class DummyClass
        {
             
        }
    }
}
