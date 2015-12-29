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
        public void IsNull_NotNullObjectArgumentNullExceptionConfigured_ThrowsArgumentNullException()
        {
            var dummy = new DummyClass();

            Should.Throw<ArgumentNullException>(() => Check.AndThrowThisWhenFails<ArgumentNullException>().If(dummy).IsNull());
        }

        [Fact]
        public void IsNull_NotNullObjectArgumentNullExceptionConfiguredWithFactory_ThrowsArgumentNullException()
        {
            var dummy = new DummyClass();

            Should.Throw<ArgumentNullException>(() => Check.AndThrowThisWhenFails(() => new ArgumentNullException()).If(dummy).IsNull());
        }

        [Fact]
        public void IsNotNull_NullObject_ThrowsArgumentNullException()
        {
            DummyClass dummy = null;

            Should.Throw<ArgumentNullException>(() => Check.If(dummy).IsNotNull());
        }

        [Fact]
        public void IsNotNull_NullObjectDummyExceptionConfigured_ThrowsDummyException()
        {
            DummyClass dummy = null;

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails<DummyException>().If(dummy).IsNotNull());
        }

        [Fact]
        public void IsNotNull_NullObjectDummyExceptionConfiguredWithFactory_ThrowsDummyException()
        {
            DummyClass dummy = null;

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails(() => new DummyException()).If(dummy).IsNotNull());
        }
    }
}
