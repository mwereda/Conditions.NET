using System;
using Shouldly;
using Xunit;

namespace Conditions.Tests
{
    public class StringComplexExtensionsTests
    {
        [Fact]
        public void IsNullOrEmpty_AndObjectWithTrueResultAndNullString_ReturnsTrue()
        {
            string name = null;
            var andCondition = new And<string>(name, true);

            var result = andCondition.IsNullOrEmpty();

            result.Result.ShouldBe(true);
        }

        [Fact]
        public void IsNullOrEmpty_AndObjectWithTrueResultAndEmptyString_ReturnsTrue()
        {
            string name = string.Empty;
            var andCondition = new And<string>(name, true);

            var result = andCondition.IsNullOrEmpty();

            result.Result.ShouldBe(true);
        }

        [Fact]
        public void IsNullOrEmpty_AndObjectWithTrueResultAndStringWithValue_ReturnsFalse()
        {
            string name = "value";
            var andCondition = new And<string>(name, true);

            var result = andCondition.IsNullOrEmpty();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsNullOrEmpty_AndObjectWithFalseResultAndNullString_ReturnsFalse()
        {
            string name = null;
            var andCondition = new And<string>(name, false);

            var result = andCondition.IsNullOrEmpty();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsNullOrEmpty_AndObjectWithFalseResultAndEmptyString_ReturnsFalse()
        {
            string name = string.Empty;
            var andCondition = new And<string>(name, false);

            var result = andCondition.IsNullOrEmpty();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsNullOrEmpty_AndObjectWithFalseResultAndStringWithValue_ReturnsFalse()
        {
            string name = "value";
            var andCondition = new And<string>(name, false);

            var result = andCondition.IsNullOrEmpty();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsNotNullOrEmpty_AndObjectWithTrueResultAndNullString_ReturnsFalse()
        {
            string name = null;
            var andCondition = new And<string>(name, true);

            var result = andCondition.IsNotNullOrEmpty();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsNotNullOrEmpty_AndObjectWithTrueResultAndEmptyString_ReturnsFalse()
        {
            string name = string.Empty;
            var andCondition = new And<string>(name, true);

            var result = andCondition.IsNotNullOrEmpty();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsNotNullOrEmpty_AndObjectWithTrueResultAndStringWithValue_ReturnsTrue()
        {
            string name = "value";
            var andCondition = new And<string>(name, true);

            var result = andCondition.IsNotNullOrEmpty();

            result.Result.ShouldBe(true);
        }

        [Fact]
        public void IsNotNullOrEmpty_AndObjectWithFalseResultAndNullString_ReturnsFalse()
        {
            string name = null;
            var andCondition = new And<string>(name, false);

            var result = andCondition.IsNotNullOrEmpty();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsNotNullOrEmpty_AndObjectWithFalseResultAndEmptyString_ReturnsFalse()
        {
            string name = string.Empty;
            var andCondition = new And<string>(name, false);

            var result = andCondition.IsNotNullOrEmpty();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsNotNullOrEmpty_AndObjectWithFalseResultAndStringWithValue_ReturnsFalse()
        {
            string name = "value";
            var andCondition = new And<string>(name, false);

            var result = andCondition.IsNotNullOrEmpty();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsGuid_AndObjectWithTrueResultAndNotValidGuid_ReturnsFalse()
        {
            string guid = "000123123";
            var andCondition = new And<string>(guid, true);

            var result = andCondition.IsGuid();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsGuid_AndObjectWithTrueResultAndValidGuid_ReturnsTrue()
        {
            string guid = Guid.NewGuid().ToString();
            var andCondition = new And<string>(guid, true);

            var result = andCondition.IsGuid();

            result.Result.ShouldBe(true);
        }

        [Fact]
        public void IsGuid_AndObjectWithFalseResultAndNotValidGuid_ReturnsFalse()
        {
            string guid = "000123123";
            var andCondition = new And<string>(guid, false);

            var result = andCondition.IsGuid();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsGuid_AndObjectWithFalseResultAndValidGuid_ReturnsFalse()
        {
            string guid = Guid.NewGuid().ToString();
            var andCondition = new And<string>(guid, false);

            var result = andCondition.IsGuid();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsEmailAddress_AndObjectWithTrueResultAndValidEmailAddress_ReturnsTrue()
        {
            string emailAddress = "test@example.com";
            var andCondition = new And<string>(emailAddress, true);

            var result = andCondition.IsEmailAddress();

            result.Result.ShouldBe(true);
        }

        [Theory]
        [InlineData("mailtest.com")]
        [InlineData("mail.test.com")]
        [InlineData("@mailtest.com")]
        [InlineData("@!$^@%!*&@example.com")]
        public void IsEmailAddress_AndObjectWithTrueResultAndInvalidEmailAddress_ReturnsFalse(string emailAddress)
        {
            var andCondition = new And<string>(emailAddress, true);

            var result = andCondition.IsEmailAddress();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsEmailAddress_AndObjectWithFalseResultAndValidEmailAddress_ReturnsFalse()
        {
            string emailAddress = "test@example.com";
            var andCondition = new And<string>(emailAddress, false);

            var result = andCondition.IsEmailAddress();

            result.Result.ShouldBe(false);
        }

        [Theory]
        [InlineData("mailtest.com")]
        [InlineData("mail.test.com")]
        [InlineData("@mailtest.com")]
        [InlineData("@!$^@%!*&@example.com")]
        public void IsEmailAddress_AndObjectWithFalseResultAndInvalidEmailAddress_ReturnsFalse(string emailAddress)
        {
            var andCondition = new And<string>(emailAddress, false);

            var result = andCondition.IsEmailAddress();

            result.Result.ShouldBe(false);
        }

        [Theory]
        [InlineData("first string", 12)]
        [InlineData("short", 5)]
        [InlineData("really long string", 18)]
        public void HasLength_AndObjectWithTrueResultAndStringHasExpectedLength_ReturnsTrue(string @string, int expectedLength)
        {
            var andCondition = new And<string>(@string, true);

            var result = andCondition.HasLength(expectedLength);

            result.Result.ShouldBe(true);
        }

        [Theory]
        [InlineData("xyz", 2)]
        [InlineData("shorter", 5)]
        [InlineData("long string", 18)]
        public void HasLength_AndObjectWithTrueResultAndStringHasNotExpectedLength_ReturnsFalse(string @string, int expectedLength)
        {
            var andCondition = new And<string>(@string, true);

            var result = andCondition.HasLength(expectedLength);

            result.Result.ShouldBe(false);
        }


        [Theory]
        [InlineData("first string", 12)]
        [InlineData("short", 5)]
        [InlineData("really long string", 18)]
        public void HasLength_AndObjectWithFalseResultAndStringHasExpectedLength_ReturnsFalse(string @string, int expectedLength)
        {
            var andCondition = new And<string>(@string, false);

            var result = andCondition.HasLength(expectedLength);

            result.Result.ShouldBe(false);
        }

        [Theory]
        [InlineData("xyz", 2)]
        [InlineData("shorter", 5)]
        [InlineData("long string", 18)]
        public void HasLength_AndObjectWithFalseResultAndStringHasNotExpectedLength_ReturnsFalse(string @string, int expectedLength)
        {
            var andCondition = new And<string>(@string, false);

            var result = andCondition.HasLength(expectedLength);

            result.Result.ShouldBe(false);
        }

        [Theory]
        [InlineData("bla bla", 7)]
        [InlineData("bla bla", 4)]
        [InlineData("new string", 3)]
        [InlineData("new string", 10)]
        public void HasLengthAtLeast_AndObjectWithTrueResultAndStringLongerOrEqualGivenValue_ReturnsTrue(string @string, int minimalLength)
        {
            var andCondition = new And<string>(@string, true);

            var result = andCondition.HasLengthAtLeast(minimalLength);

            result.Result.ShouldBe(true);
        }

        [Theory]
        [InlineData("bla bla", 17)]
        [InlineData("bla bla", 14)]
        [InlineData("new string", 23)]
        [InlineData("new string", 102)]
        public void HasLengthAtLeast_AndObjectWithTrueResultAndStringNotLongerOrEqualGivenValue_ReturnsFalse(string @string, int minimalLength)
        {
            var andCondition = new And<string>(@string, true);

            var result = andCondition.HasLengthAtLeast(minimalLength);

            result.Result.ShouldBe(false);
        }

        [Theory]
        [InlineData("bla bla", 7)]
        [InlineData("bla bla", 4)]
        [InlineData("new string", 3)]
        [InlineData("new string", 10)]
        public void HasLengthAtLeast_AndObjectWithFalseResultAndStringLongerOrEqualGivenValue_ReturnsFalse(string @string, int minimalLength)
        {
            var andCondition = new And<string>(@string, false);

            var result = andCondition.HasLengthAtLeast(minimalLength);

            result.Result.ShouldBe(false);
        }

        [Theory]
        [InlineData("bla bla", 17)]
        [InlineData("bla bla", 14)]
        [InlineData("new string", 23)]
        [InlineData("new string", 102)]
        public void HasLengthAtLeast_AndObjectWithFalseResultAndStringNotLongerOrEqualGivenValue_ReturnsFalse(string @string, int minimalLength)
        {
            var andCondition = new And<string>(@string, false);

            var result = andCondition.HasLengthAtLeast(minimalLength);

            result.Result.ShouldBe(false);
        }

        [Theory]
        [InlineData("123", @"\d{3}")]
        [InlineData("abc123", @"[a-z]{3}\d{3}")]
        public void Matches_AndObjectWithTrueResultAndStringMatchesPattern_ReturnsTrue(string @string, string pattern)
        {
            var andCondition = new And<string>(@string, true);

            var result = andCondition.Matches(pattern);

            result.Result.ShouldBe(true);
        }

        [Theory]
        [InlineData("123", @"^\d$")]
        [InlineData("abc123", @"}\d{3}")]
        public void Matches_AndObjectWithTrueResultAndStringDoesNotMatchPattern_ReturnsFalse(string @string, string pattern)
        {
            var andCondition = new And<string>(@string, true);

            var result = andCondition.Matches(pattern);

            result.Result.ShouldBe(false);
        }

        [Theory]
        [InlineData("123", @"\d{3}")]
        [InlineData("abc123", @"[a-z]{3}\d{3}")]
        public void Matches_AndObjectWithFalseResultAndStringMatchesPattern_ReturnsFalse(string @string, string pattern)
        {
            var andCondition = new And<string>(@string, false);

            var result = andCondition.Matches(pattern);

            result.Result.ShouldBe(false);
        }

        [Theory]
        [InlineData("123", @"^\d$")]
        [InlineData("abc123", @"}\d{3}")]
        public void Matches_AndObjectWithFalseResultAndStringDoesNotMatchPattern_ReturnsFalse(string @string, string pattern)
        {
            var andCondition = new And<string>(@string, false);

            var result = andCondition.Matches(pattern);

            result.Result.ShouldBe(false);
        }
    }
}
