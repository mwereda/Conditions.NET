using System;
using Conditions.Guards.Extensions;
using Xunit;

namespace Conditions.Guards.Tests.Extensions
{
    public class ObjectChecksTests
    {
        [Fact]
        public void IsNull_NotNullObject_ThrowsArgumentException()
        {
            var dummy = new DummyClass();

            Assert.Throws<ArgumentException>(() => Check.If(dummy).IsNull());
        }

        [Fact]
        public void IsNotNull_NullObject_ThrowsArgumentNullException()
        {
            DummyClass dummy = null;

            Assert.Throws<ArgumentNullException>(() => Check.If(dummy).IsNotNull());
        }

        class DummyClass
        {             
        }
    }
}
