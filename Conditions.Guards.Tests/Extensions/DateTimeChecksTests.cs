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

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFails<InvalidOperationException>().If(currentDateTime).IsGreaterThan(currentDateTime));
            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFails<InvalidOperationException>().If(currentDateTime).IsGreaterThan(currentDateTime.AddDays(1)));
            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFails<InvalidOperationException>().If(currentDateTime).IsGreaterThan(currentDateTime.AddMilliseconds(1)));
            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFails<InvalidOperationException>().If(currentDateTime).IsGreaterThan(currentDateTime.AddHours(1)));
            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFails<InvalidOperationException>().If(currentDateTime).IsGreaterThan(currentDateTime.AddMinutes(1)));
            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFails<InvalidOperationException>().If(currentDateTime).IsGreaterThan(currentDateTime.AddSeconds(1)));
        }

        [Fact]
        public void IsGreaterThan_DateTimeIsLowerOrEqualReferenceDateSetToThrowInvalidOperationExceptionWithFactory_ThrowsInvalidOperationException()
        {
            var currentDateTime = DateTime.Now;

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFails(() => new InvalidOperationException()).If(currentDateTime).IsGreaterThan(currentDateTime));
            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFails(() => new InvalidOperationException()).If(currentDateTime).IsGreaterThan(currentDateTime.AddDays(1)));
            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFails(() => new InvalidOperationException()).If(currentDateTime).IsGreaterThan(currentDateTime.AddMilliseconds(1)));
            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFails(() => new InvalidOperationException()).If(currentDateTime).IsGreaterThan(currentDateTime.AddHours(1)));
            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFails(() => new InvalidOperationException()).If(currentDateTime).IsGreaterThan(currentDateTime.AddMinutes(1)));
            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFails(() => new InvalidOperationException()).If(currentDateTime).IsGreaterThan(currentDateTime.AddSeconds(1)));
        }

        [Fact]
        public void IsGreaterThan_DateTimeIsLowerOrEqualReferenceDateSetToThrowDummyException_ThrowsDummyException()
        {
            var currentDateTime = DateTime.Now;

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails<DummyException>().If(currentDateTime).IsGreaterThan(currentDateTime));
            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails<DummyException>().If(currentDateTime).IsGreaterThan(currentDateTime.AddDays(1)));
            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails<DummyException>().If(currentDateTime).IsGreaterThan(currentDateTime.AddMilliseconds(1)));
            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails<DummyException>().If(currentDateTime).IsGreaterThan(currentDateTime.AddHours(1)));
            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails<DummyException>().If(currentDateTime).IsGreaterThan(currentDateTime.AddMinutes(1)));
            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails<DummyException>().If(currentDateTime).IsGreaterThan(currentDateTime.AddSeconds(1)));
        }

        [Fact]
        public void IsGreaterThan_DateTimeIsLowerOrEqualReferenceDateSetToThrowDummyExceptionWithFactory_ThrowsDummyException()
        {
            var currentDateTime = DateTime.Now;

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails(() => new DummyException()).If(currentDateTime).IsGreaterThan(currentDateTime));
            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails(() => new DummyException()).If(currentDateTime).IsGreaterThan(currentDateTime.AddDays(1)));
            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails(() => new DummyException()).If(currentDateTime).IsGreaterThan(currentDateTime.AddMilliseconds(1)));
            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails(() => new DummyException()).If(currentDateTime).IsGreaterThan(currentDateTime.AddHours(1)));
            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails(() => new DummyException()).If(currentDateTime).IsGreaterThan(currentDateTime.AddMinutes(1)));
            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails(() => new DummyException()).If(currentDateTime).IsGreaterThan(currentDateTime.AddSeconds(1)));
        }
    }
}
