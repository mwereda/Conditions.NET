using Shouldly;
using System;
using Xunit;

namespace Conditions.Guards.Tests
{
    public class ExceptionConfigurationTests
    {
        [Fact]
        public void Throw_ExceptionNotConfigured_ThrowsInvalidOperationException()
        {
            var exceptionConfiguration = new ExceptionConfiguration();

            Should.Throw<InvalidOperationException>(() => exceptionConfiguration.Throw());
        }

        [Fact]
        public void Throw_ArgumentExceptionConfigured_ThrowsArgumentException()
        {
            var exceptionConfiguration = new ExceptionConfiguration();
            exceptionConfiguration.ThrowsException(() => new ArgumentException());

            Should.Throw<ArgumentException>(() => exceptionConfiguration.Throw());
        }

        [Fact]
        public void Throw_ArgumentNullExceptionConfigured_ThrowsNullArgumentException()
        {
            var exceptionConfiguration = new ExceptionConfiguration();
            exceptionConfiguration.ThrowsException(() => new ArgumentNullException());

            Should.Throw<ArgumentNullException>(() => exceptionConfiguration.Throw());
        }

        [Fact]
        public void Throw_DivideByZeroExceptionConfigured_ThrowsNullDivideByZeroException()
        {
            var exceptionConfiguration = new ExceptionConfiguration();
            exceptionConfiguration.ThrowsException(() => new DivideByZeroException());

            Should.Throw<DivideByZeroException>(() => exceptionConfiguration.Throw());
        }

        [Fact]
        public void Throw_DummyExceptionConfigured_ThrowsNullDummyException()
        {
            var exceptionConfiguration = new ExceptionConfiguration();
            exceptionConfiguration.ThrowsException(() => new DummyException());

            Should.Throw<DummyException>(() => exceptionConfiguration.Throw());
        }

        [Fact]
        public void Throw_ArgumentExceptionConfiguredWithGenericMethod_ThrowsArgumentException()
        {
            var exceptionConfiguration = new ExceptionConfiguration();
            exceptionConfiguration.ThrowsException<ArgumentException>();

            Should.Throw<ArgumentException>(() => exceptionConfiguration.Throw());
        }

        [Fact]
        public void Throw_ArgumentNullExceptionConfiguredWithGenericMethod_ThrowsNullArgumentException()
        {
            var exceptionConfiguration = new ExceptionConfiguration();
            exceptionConfiguration.ThrowsException<ArgumentNullException>();

            Should.Throw<ArgumentNullException>(() => exceptionConfiguration.Throw());
        }

        [Fact]
        public void Throw_DivideByZeroExceptionConfiguredWithGenericMethod_ThrowsNullDivideByZeroException()
        {
            var exceptionConfiguration = new ExceptionConfiguration();
            exceptionConfiguration.ThrowsException<DivideByZeroException>();

            Should.Throw<DivideByZeroException>(() => exceptionConfiguration.Throw());
        }

        [Fact]
        public void Throw_DummyExceptionConfiguredWithGenericMethod_ThrowsNullDummyException()
        {
            var exceptionConfiguration = new ExceptionConfiguration();
            exceptionConfiguration.ThrowsException<DummyException>();

            Should.Throw<DummyException>(() => exceptionConfiguration.Throw());
        }
    }
}
