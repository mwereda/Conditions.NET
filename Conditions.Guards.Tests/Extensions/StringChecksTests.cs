using System;
using Shouldly;
using Xunit;

namespace Conditions.Guards.Tests.Extensions
{
    public class StringChecksTests
    {
        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void IsNotNullOrEmpty_StringIsNullOrEmpty_ThrowsArgumentNullException(string invalidString)
        {
            Should.Throw<ArgumentNullException>(() => Check.If(invalidString).IsNotNullOrEmpty());
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void IsNotNullOrEmpty_StringIsNullOrEmptyInvalidOperationExceptionConfigured_ThrowsInvalidOperationException(string invalidString)
        {
            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFails<InvalidOperationException>().If(invalidString).IsNotNullOrEmpty());
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void IsNotNullOrEmpty_StringIsNullOrEmptyInvalidOperationExceptionConfiguredWithFactory_ThrowsInvalidOperationException(string invalidString)
        {
            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFails(() => new InvalidOperationException()).If(invalidString).IsNotNullOrEmpty());
        }

        [Fact]
        public void IsGuid_StringIsInvalidGuid_ThrowsArgumentException()
        {
            const string invalidGuid = "1234vcxvxcv34324";

            Should.Throw<ArgumentException>(() => Check.If(invalidGuid).IsGuid());
        }

        [Fact]
        public void IsGuid_StringIsInvalidGuidDummyExceptionConfigured_ThrowsDummyException()
        {
            const string invalidGuid = "1234vcxvxcv34324";

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails<DummyException>().If(invalidGuid).IsGuid());
        }

        [Fact]
        public void IsGuid_StringIsInvalidGuidDummyExceptionConfiguredWithFactory_ThrowsDummyException()
        {
            const string invalidGuid = "1234vcxvxcv34324";

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails(() => new DummyException()).If(invalidGuid).IsGuid());
        }

        [Fact]
        public void IsEmailAddress_StringIsInvalidEmailAddress_ThrowsArgumentException()
        {
            const string invalidEmailAddress = "mail.example.com";

            Should.Throw<ArgumentException>(() => Check.If(invalidEmailAddress).IsEmailAddress());
        }

        [Fact]
        public void IsEmailAddress_StringIsInvalidEmailAddressNullReferenceExceptionConfigured_ThrowsNullReferenceException()
        {
            const string invalidEmailAddress = "mail.example.com";

            Should.Throw<NullReferenceException>(() => Check.AndThrowThisWhenFails<NullReferenceException>().If(invalidEmailAddress).IsEmailAddress());
        }

        [Fact]
        public void IsEmailAddress_StringIsInvalidEmailAddressNullReferenceExceptionConfiguredWithFactory_ThrowsNullReferenceException()
        {
            const string invalidEmailAddress = "mail.example.com";

            Should.Throw<NullReferenceException>(() => Check.AndThrowThisWhenFails(() => new NullReferenceException()).If(invalidEmailAddress).IsEmailAddress());
        }

        [Fact]
        public void HasLength_StringHasNotExpectedLength_ThrowsArgumentException()
        {
            const string sampleString = "sample";
            const int expectedLength = 3;

            Should.Throw<ArgumentException>(() => Check.If(sampleString).HasLength(expectedLength));
        }

        [Fact]
        public void HasLength_StringHasNotExpectedLengthInvalidCastExceptionConfigured_ThrowsInvalidCastException()
        {
            const string sampleString = "sample";
            const int expectedLength = 3;

            Should.Throw<InvalidCastException>(() => Check.AndThrowThisWhenFails<InvalidCastException>().If(sampleString).HasLength(expectedLength));
        }

        [Fact]
        public void HasLength_StringHasNotExpectedLengthInvalidCastExceptionConfiguredWithFactory_ThrowsInvalidCastException()
        {
            const string sampleString = "sample";
            const int expectedLength = 3;

            Should.Throw<InvalidCastException>(() => Check.AndThrowThisWhenFails(() => new InvalidCastException()).If(sampleString).HasLength(expectedLength));
        }

        [Fact]
        public void HasLengthAtLeast_StringShorterThanExpected_ThrowsArgumentException()
        {
            const string sampleString = "testing";
            const int minimalLength = 10;

            Should.Throw<ArgumentException>(() => Check.If(sampleString).HasLengthAtLeast(minimalLength));
        }

        [Fact]
        public void HasLengthAtLeast_StringShorterThanExpectedInvalidTimeZoneExceptionConfigured_ThrowsInvalidTimeZoneException()
        {
            const string sampleString = "testing";
            const int minimalLength = 10;

            Should.Throw<InvalidTimeZoneException>(() => Check.AndThrowThisWhenFails<InvalidTimeZoneException>().If(sampleString).HasLengthAtLeast(minimalLength));
        }

        [Fact]
        public void HasLengthAtLeast_StringShorterThanExpectedInvalidTimeZoneExceptionConfiguredWithFactory_ThrowsInvalidTimeZoneException()
        {
            const string sampleString = "testing";
            const int minimalLength = 10;

            Should.Throw<InvalidTimeZoneException>(() => Check.AndThrowThisWhenFails(() => new InvalidTimeZoneException()).If(sampleString).HasLengthAtLeast(minimalLength));
        }

        [Theory]
        [InlineData("123", @"^\d$")]
        [InlineData("abc123", @"}\d{3}")]
        public void Matches_StringDoesNotMatchPattern_ThrowsArgumentException(string @string, string pattern)
        {
            Should.Throw<ArgumentException>(() => Check.If(@string).Matches(pattern));
        }

        [Theory]
        [InlineData("123", @"^\d$")]
        [InlineData("abc123", @"}\d{3}")]
        public void Matches_StringDoesNotMatchPatternDummyExceptionConfigured_ThrowsDummyException(string @string, string pattern)
        {
            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails<DummyException>().If(@string).Matches(pattern));
        }

        [Theory]
        [InlineData("123", @"^\d$")]
        [InlineData("abc123", @"}\d{3}")]
        public void Matches_StringDoesNotMatchPatternDummyExceptionConfiguredWithFactory_ThrowsDummyException(string @string, string pattern)
        {
            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFails(() => new DummyException()).If(@string).Matches(pattern));
        }
    }
}
