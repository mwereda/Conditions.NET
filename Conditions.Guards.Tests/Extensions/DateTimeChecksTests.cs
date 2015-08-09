using System;
using Shouldly;
using Xunit;

namespace Conditions.Guards.Tests.Extensions
{
    public class DateTimeChecksTests
    {
        [Fact]
        public void IsGreaterThan_DateTimeIsLowerOrEqualReferenceDate_ThrowsArgumentException()
        {
            var currentDateTime = DateTime.Now;

            Should.Throw<ArgumentException>(() => Check.If(currentDateTime).IsGreaterThan(currentDateTime));
            Should.Throw<ArgumentException>(() => Check.If(currentDateTime).IsGreaterThan(currentDateTime.AddDays(1)));
            Should.Throw<ArgumentException>(() => Check.If(currentDateTime).IsGreaterThan(currentDateTime.AddMilliseconds(1)));
            Should.Throw<ArgumentException>(() => Check.If(currentDateTime).IsGreaterThan(currentDateTime.AddHours(1)));
            Should.Throw<ArgumentException>(() => Check.If(currentDateTime).IsGreaterThan(currentDateTime.AddMinutes(1)));
            Should.Throw<ArgumentException>(() => Check.If(currentDateTime).IsGreaterThan(currentDateTime.AddSeconds(1)));
        }

        [Fact]
        public void IsGreaterThan_DateTimeIsLowerOrEqualReferenceDateSetToThrowInvalidOperationException_ThrowsInvalidOperationException()
        {
            var currentDateTime = DateTime.Now;

            Should.Throw<InvalidOperationException>(() => Check.If(currentDateTime).AndThrowWhenFail<InvalidOperationException>().IsGreaterThan(currentDateTime));
            Should.Throw<InvalidOperationException>(() => Check.If(currentDateTime).AndThrowWhenFail<InvalidOperationException>().IsGreaterThan(currentDateTime.AddDays(1)));
            Should.Throw<InvalidOperationException>(() => Check.If(currentDateTime).AndThrowWhenFail<InvalidOperationException>().IsGreaterThan(currentDateTime.AddMilliseconds(1)));
            Should.Throw<InvalidOperationException>(() => Check.If(currentDateTime).AndThrowWhenFail<InvalidOperationException>().IsGreaterThan(currentDateTime.AddHours(1)));
            Should.Throw<InvalidOperationException>(() => Check.If(currentDateTime).AndThrowWhenFail<InvalidOperationException>().IsGreaterThan(currentDateTime.AddMinutes(1)));
            Should.Throw<InvalidOperationException>(() => Check.If(currentDateTime).AndThrowWhenFail<InvalidOperationException>().IsGreaterThan(currentDateTime.AddSeconds(1)));
        }

        [Fact]
        public void IsGreaterThan_DateTimeIsLowerOrEqualReferenceDateSetToThrowInvalidOperationExceptionWithFactory_ThrowsInvalidOperationException()
        {
            var currentDateTime = DateTime.Now;

            Should.Throw<InvalidOperationException>(() => Check.If(currentDateTime).AndThrowWhenFail(()=> new InvalidOperationException()).IsGreaterThan(currentDateTime));
            Should.Throw<InvalidOperationException>(() => Check.If(currentDateTime).AndThrowWhenFail(() => new InvalidOperationException()).IsGreaterThan(currentDateTime.AddDays(1)));
            Should.Throw<InvalidOperationException>(() => Check.If(currentDateTime).AndThrowWhenFail(() => new InvalidOperationException()).IsGreaterThan(currentDateTime.AddMilliseconds(1)));
            Should.Throw<InvalidOperationException>(() => Check.If(currentDateTime).AndThrowWhenFail(() => new InvalidOperationException()).IsGreaterThan(currentDateTime.AddHours(1)));
            Should.Throw<InvalidOperationException>(() => Check.If(currentDateTime).AndThrowWhenFail(() => new InvalidOperationException()).IsGreaterThan(currentDateTime.AddMinutes(1)));
            Should.Throw<InvalidOperationException>(() => Check.If(currentDateTime).AndThrowWhenFail(() => new InvalidOperationException()).IsGreaterThan(currentDateTime.AddSeconds(1)));
        }

        [Fact]
        public void IsGreaterThan_DateTimeIsLowerOrEqualReferenceDateSetToThrowDummyException_ThrowsDummyException()
        {
            var currentDateTime = DateTime.Now;

            Should.Throw<DummyException>(() => Check.If(currentDateTime).AndThrowWhenFail<DummyException>().IsGreaterThan(currentDateTime));
            Should.Throw<DummyException>(() => Check.If(currentDateTime).AndThrowWhenFail<DummyException>().IsGreaterThan(currentDateTime.AddDays(1)));
            Should.Throw<DummyException>(() => Check.If(currentDateTime).AndThrowWhenFail<DummyException>().IsGreaterThan(currentDateTime.AddMilliseconds(1)));
            Should.Throw<DummyException>(() => Check.If(currentDateTime).AndThrowWhenFail<DummyException>().IsGreaterThan(currentDateTime.AddHours(1)));
            Should.Throw<DummyException>(() => Check.If(currentDateTime).AndThrowWhenFail<DummyException>().IsGreaterThan(currentDateTime.AddMinutes(1)));
            Should.Throw<DummyException>(() => Check.If(currentDateTime).AndThrowWhenFail<DummyException>().IsGreaterThan(currentDateTime.AddSeconds(1)));
        }

        [Fact]
        public void IsGreaterThan_DateTimeIsLowerOrEqualReferenceDateSetToThrowDummyExceptionWithFactory_ThrowsDummyException()
        {
            var currentDateTime = DateTime.Now;

            Should.Throw<DummyException>(() => Check.If(currentDateTime).AndThrowWhenFail(() => new DummyException()).IsGreaterThan(currentDateTime));
            Should.Throw<DummyException>(() => Check.If(currentDateTime).AndThrowWhenFail(() => new DummyException()).IsGreaterThan(currentDateTime.AddDays(1)));
            Should.Throw<DummyException>(() => Check.If(currentDateTime).AndThrowWhenFail(() => new DummyException()).IsGreaterThan(currentDateTime.AddMilliseconds(1)));
            Should.Throw<DummyException>(() => Check.If(currentDateTime).AndThrowWhenFail(() => new DummyException()).IsGreaterThan(currentDateTime.AddHours(1)));
            Should.Throw<DummyException>(() => Check.If(currentDateTime).AndThrowWhenFail(() => new DummyException()).IsGreaterThan(currentDateTime.AddMinutes(1)));
            Should.Throw<DummyException>(() => Check.If(currentDateTime).AndThrowWhenFail(() => new DummyException()).IsGreaterThan(currentDateTime.AddSeconds(1)));
        }
    }
}
