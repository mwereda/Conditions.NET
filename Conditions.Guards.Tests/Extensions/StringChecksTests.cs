using System;
using Conditions.Guards.Extensions;
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
    }
}
