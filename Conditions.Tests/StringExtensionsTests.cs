using System;
using Shouldly;
using Xunit;

namespace Conditions.Tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void IsNullOrEmpty_NullString_ReturnsTrue()
        {
            string name = null;

            name.IsNullOrEmpty().ShouldBe(true);
        }

        [Fact]
        public void IsNullOrEmpty_EmptyString_ReturnsTrue()
        {
            string name = string.Empty;

            name.IsNullOrEmpty().ShouldBe(true);
        }

        [Fact]
        public void IsNullOrEmpty_StringWithValue_ReturnsFalse()
        {
            string name = "value";

            name.IsNullOrEmpty().ShouldBe(false);
        }

        [Fact]
        public void IsNotNullOrEmpty_NullString_ReturnsFalse()
        {
            string name = null;

            name.IsNotNullOrEmpty().ShouldBe(false);
        }

        [Fact]
        public void IsNotNullOrEmpty_EmptyString_ReturnsFalse()
        {
            string name = string.Empty;

	        name.IsNotNullOrEmpty().ShouldBe(false);
        }

        [Fact]
        public void IsNotNullOrEmpty_StringWithValue_ReturnsTrue()
        {
            string name = "value";

            name.IsNotNullOrEmpty().ShouldBe(true);
        }

        [Fact]
        public void IsGuid_NotValidGuid_ReturnsFalse()
        {
            string guid = "000123123";

	        guid.IsGuid().ShouldBe(false);
        }

        [Fact]
        public void IsGuid_ValidGuid_ReturnsTrue()
        {
            string guid = Guid.NewGuid().ToString();

            guid.IsGuid().ShouldBe(true);
        }

        [Fact]
        public void IsEmailAddress_ValidEmailAddress_ReturnsTrue()
        {
            string emailAddress = "test@example.com";

            emailAddress.IsEmailAddress().ShouldBe(true);
        }

        [Theory]
        [InlineData("mailtest.com")]
        [InlineData("mail.test.com")]
        [InlineData("@mailtest.com")]
        [InlineData("@!$^@%!*&@example.com")]
        public void IsEmailAddress_InvalidEmailAddress_ReturnsFalse(string emailAddress)
        {
            emailAddress.IsEmailAddress().ShouldBe(false);
        }

        [Theory]
        [InlineData("first string", 12)]
        [InlineData("short", 5)]
        [InlineData("really long string", 18)]
        public void HasLength_StringHasExpectedLength_ReturnsTrue(string @string, int expectedLength)
        {
            @string.HasLength(expectedLength).ShouldBe(true);
        }

        [Theory]
        [InlineData("xyz", 2)]
        [InlineData("shorter", 5)]
        [InlineData("long string", 18)]
        public void HasLength_StringHasNotExpectedLength_ReturnsFalse(string @string, int expectedLength)
        {
            @string.HasLength(expectedLength).ShouldBe(false);
        }

        [Theory]
        [InlineData("bla bla", 7)]
        [InlineData("bla bla", 4)]
        [InlineData("new string", 3)]
        [InlineData("new string", 10)]
        public void HasLengthAtLeast_StringLongerOrEqualGivenValue_ReturnsTrue(string @string, int minimalLength)
        {
            @string.HasLengthAtLeast(minimalLength).ShouldBe(true);
        }

        [Theory]
        [InlineData("bla bla", 17)]
        [InlineData("bla bla", 14)]
        [InlineData("new string", 23)]
        [InlineData("new string", 102)]
        public void HasLengthAtLeast_StringNotLongerOrEqualGivenValue_ReturnsFalse(string @string, int minimalLength)
        {
            @string.HasLengthAtLeast(minimalLength).ShouldBe(false);
        }

        [Theory]
        [InlineData("123", @"\d{3}")]
        [InlineData("abc123", @"[a-z]{3}\d{3}")]
        public void Matches_StringMatchesPattern_ReturnsTrue(string @string, string pattern)
        {
            @string.Matches(pattern).ShouldBe(true);
        }

        [Theory]
        [InlineData("123", @"^\d$")]
        [InlineData("abc123", @"}\d{3}")]
        public void Matches_StringDoesNotMatchPattern_ReturnsFalse(string @string, string pattern)
        {
            @string.Matches(pattern).ShouldBe(false);
        }
    }
}
