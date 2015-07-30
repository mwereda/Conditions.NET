using System;
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
            Assert.Throws<ArgumentNullException>(() => Check.If(invalidString).IsNotNullOrEmpty());
        }        

        [Fact]
        public void IsGuid_StringIsInvalidGuid_ThrowsArgumentException()
        {
            const string invalidGuid = "1234vcxvxcv34324";

            Assert.Throws<ArgumentException>(() => Check.If(invalidGuid).IsGuid());
        }

        [Fact]
        public void IsEmailAddress_StringIsInvalidEmailAddress_ThrowsArgumentException()
        {
            const string invalidEmailAddress = "mail.example.com";

            Assert.Throws<ArgumentException>(() => Check.If(invalidEmailAddress).IsEmailAddress());
        }

        [Fact]
        public void HasLength_StringHasNotExpectedLength_ThrowsArgumentException()
        {
            const string sampleString = "sample";
            const int expectedLength = 3;

            Assert.Throws<ArgumentException>(() => Check.If(sampleString).HasLength(expectedLength));
        }

        [Fact]
        public void HasLengthAtLeast_StringShorterThanExpected_ThrowsArgumentException()
        {
            const string sampleString = "testing";
            const int minimalLength = 10;

            Assert.Throws<ArgumentException>(() => Check.If(sampleString).HasLengthAtLeast(minimalLength));
        }

		[Theory]
		[InlineData("123", @"^\d$")]
		[InlineData("abc123", @"}\d{3}")]
		public void Matches_StringDoesNotMatchPattern_ThrowsArgumentException(string @string, string pattern)
		{
			Assert.Throws<ArgumentException>(() => Check.If(@string).Matches(pattern));
		}
    }
}
