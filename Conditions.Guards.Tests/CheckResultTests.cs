using Shouldly;
using System;
using Xunit;

namespace Conditions.Guards.Tests
{
    public class CheckResultTests
    {
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Constructor_IsValidSet_ReturnsProperValueForIsValid(bool isValid)
        {
            var checkResult = new CheckResult(isValid);

            checkResult.IsValid.ShouldBe(isValid);
        }

        [Fact]
        public void Throw_ExceptionNotConfigured_ThrowsInvalidOperationException()
        {
            var checkResult = new CheckResult(false);

            Should.Throw<InvalidOperationException>(() => checkResult.Throw());
        }

        [Fact]
        public void Throw_ArgumentExceptionConfigured_ThrowsArgumentException()
        {
            var checkResult = new CheckResult(false);
            checkResult.ThrowsException(() => new ArgumentException());

            Should.Throw<ArgumentException>(() => checkResult.Throw());
        }

        [Fact]
        public void Throw_ArgumentNullExceptionConfigured_ThrowsNullArgumentException()
        {
            var checkResult = new CheckResult(false);
            checkResult.ThrowsException(() => new ArgumentNullException());

            Should.Throw<ArgumentNullException>(() => checkResult.Throw());
        }

        [Fact]
        public void Throw_DivideByZeroExceptionConfigured_ThrowsNullDivideByZeroException()
        {
            var checkResult = new CheckResult(false);
            checkResult.ThrowsException(() => new DivideByZeroException());

            Should.Throw<DivideByZeroException>(() => checkResult.Throw());
        }

        [Fact]
        public void Throw_DummyExceptionConfigured_ThrowsNullDummyException()
        {
            var checkResult = new CheckResult(false);
            checkResult.ThrowsException(() => new DummyException());

            Should.Throw<DummyException>(() => checkResult.Throw());
        }
    }
}
