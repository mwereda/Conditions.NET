using System;
using Xunit;

namespace Conditions.Tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void IsNullOrEmpty_NullString_ReturnsTrue()
        {
            string name = null;

            Assert.True(name.IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmpty_EmptyString_ReturnsTrue()
        {
            string name = string.Empty;

            Assert.True(name.IsNullOrEmpty());
        }

        [Fact]
        public void IsNullOrEmpty_StringWithValue_ReturnsFalse()
        {
            string name = "value";

            Assert.False(name.IsNullOrEmpty());
        }

        [Fact]
        public void IsNotNullOrEmpty_NullString_ReturnsFalse()
        {
            string name = null;

            Assert.False(name.IsNotNullOrEmpty());
        }

        [Fact]
        public void IsNotNullOrEmpty_EmptyString_ReturnsFalse()
        {
            string name = string.Empty;

            Assert.False(name.IsNotNullOrEmpty());
        }

        [Fact]
        public void IsNotNullOrEmpty_StringWithValue_ReturnsTrue()
        {
            string name = "value";

            Assert.True(name.IsNotNullOrEmpty());
        }

        [Fact]
        public void IsGuid_NotValidGuid_ReturnsFalse()
        {
            string guid = "000123123";

            Assert.False(guid.IsGuid());
        }

        [Fact]
        public void IsGuid_ValidGuid_ReturnsTrue()
        {
            string guid = Guid.NewGuid().ToString();

            Assert.True(guid.IsGuid());
        }

        [Fact]
        public void IsEmailAddress_ValidEmailAddress_ReturnsTrue()
        {
            string emailAddress = "test@example.com";

            Assert.True(emailAddress.IsEmailAddress());
        }

        [Theory]
        [InlineData("mailtest.com")]
        [InlineData("mail.test.com")]
        [InlineData("@mailtest.com")]
        [InlineData("@!$^@%!*&@example.com")]
        public void IsEmailAddress_InvalidEmailAddress_ReturnsFalse(string emailAddress)
        {
            Assert.False(emailAddress.IsEmailAddress());
        }

        [Theory]
        [InlineData("first string", 12)]
        [InlineData("short", 5)]
        [InlineData("really long string", 18)]
        public void HasLength_StringHasExpectedLength_ReturnsTrue(string @string, int expectedLength)
        {
            Assert.True(@string.HasLength(expectedLength));
        }

        [Theory]
        [InlineData("xyz", 2)]
        [InlineData("shorter", 5)]
        [InlineData("long string", 18)]
        public void HasLength_StringHasNotExpectedLength_ReturnsFalse(string @string, int expectedLength)
        {
            Assert.False(@string.HasLength(expectedLength));
        }

        [Theory]
        [InlineData("bla bla", 7)]
        [InlineData("bla bla", 4)]
        [InlineData("new string", 3)]
        [InlineData("new string", 10)]
        public void HasLengthAtLeast_StringLongerOrEqualGivenValue_ReturnsTrue(string @string, int minimalLength)
        {
            Assert.True(@string.HasLengthAtLeast(minimalLength));
        }

        [Theory]
        [InlineData("bla bla", 17)]
        [InlineData("bla bla", 14)]
        [InlineData("new string", 23)]
        [InlineData("new string", 102)]
        public void HasLengthAtLeast_StringNotLongerOrEqualGivenValue_ReturnsFalse(string @string, int minimalLength)
        {
            Assert.False(@string.HasLengthAtLeast(minimalLength));
        }
    }
}
