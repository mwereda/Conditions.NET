using System;
using Shouldly;
using Xunit;

namespace Conditions.Guards.Tests.Extensions
{
    public class ObjectChecksTests
    {
        [Fact]
        public void IsNull_NotNullObject_ThrowsArgumentException()
        {
            var dummy = new DummyClass();

            Should.Throw<ArgumentException>(() => Check.If(dummy).IsNull());
        }

        [Fact]
        public void IsNotNull_NullObject_ThrowsArgumentNullException()
        {
            DummyClass dummy = null;

            Should.Throw<ArgumentNullException>(() => Check.If(dummy).IsNotNull());
        }
    }
}
