using System.Collections.Generic;
using System.Linq;
using Shouldly;
using Xunit;

namespace Conditions.Tests
{
    public class EnumerableAndExtensionsTests
    {
        [Fact]
        public void IsEmpty_AndObjectWithTrueResultAndCollectionEmpty_ReturnsTrue()
        {
            var list = new List<DummyClass>();
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.IsEmpty();

            result.Result.ShouldBe(true);
        }

        [Fact]
        public void IsEmpty_AndObjectWithFalseResultAndCollectionEmpty_ReturnsFalse()
        {
            var list = new List<DummyClass>();
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.IsEmpty();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsEmpty_AndObjectWithTrueResultAndCollectionNotEmpty_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.IsEmpty();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsEmpty_AndObjectWithFalseResultAndCollectionNotEmpty_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.IsEmpty();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsNullOrEmpty_AndObjectWithTrueResultAndNullList_ReturnsTrue()
        {
            List<DummyClass> nullList = null;
            var andCondition = new And<IEnumerable<DummyClass>>(nullList, true);

            var result = andCondition.IsNullOrEmpty();

            result.Result.ShouldBe(true);
        }

        [Fact]
        public void IsNullOrEmpty_AndObjectWithTrueResultAndEmptyList_ReturnsTrue()
        {
            var emptyList = Enumerable.Empty<DummyClass>();
            var andCondition = new And<IEnumerable<DummyClass>>(emptyList, true);

            var result = andCondition.IsNullOrEmpty();

            result.Result.ShouldBe(true);
        }

        [Fact]
        public void IsNullOrEmpty_AndObjectWithTrueResultAndNotNullOrEmptyList_ReturnsFalse()
        {
            var emptyList = new List<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(emptyList, true);

            var result = andCondition.IsNullOrEmpty();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsNullOrEmpty_AndObjectWithFalseResultAndNullList_ReturnsFalse()
        {
            List<DummyClass> nullList = null;
            var andCondition = new And<IEnumerable<DummyClass>>(nullList, false);

            var result = andCondition.IsNullOrEmpty();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsNullOrEmpty_AndObjectWithFalseResultAndEmptyList_ReturnsFalse()
        {
            var emptyList = Enumerable.Empty<DummyClass>();
            var andCondition = new And<IEnumerable<DummyClass>>(emptyList, false);

            var result = andCondition.IsNullOrEmpty();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsNullOrEmpty_AndObjectWithFalseResultAndNotNullOrEmptyList_ReturnsFalse()
        {
            var emptyList = new List<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(emptyList, false);

            var result = andCondition.IsNullOrEmpty();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsNotNullOrEmpty_AndObjectWithTrueResultAndNullList_ReturnsFalse()
        {
            List<DummyClass> nullList = null;
            var andCondition = new And<IEnumerable<DummyClass>>(nullList, true);

            var result = andCondition.IsNotNullOrEmpty();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsNotNullOrEmpty_AndObjectWithTrueResultAndEmptyList_ReturnsFalse()
        {
            var emptyList = Enumerable.Empty<DummyClass>();
            var andCondition = new And<IEnumerable<DummyClass>>(emptyList, true);

            var result = andCondition.IsNotNullOrEmpty();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsNotNullOrEmpty_AndObjectWithTrueResultAndNotNullOrEmptyList_ReturnsTrue()
        {
            var emptyList = new List<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(emptyList, true);

            var result = andCondition.IsNotNullOrEmpty();

            result.Result.ShouldBe(true);
        }

        [Fact]
        public void IsNotNullOrEmpty_AndObjectWithFalseResultAndNullList_ReturnsFalse()
        {
            List<DummyClass> nullList = null;
            var andCondition = new And<IEnumerable<DummyClass>>(nullList, false);

            var result = andCondition.IsNotNullOrEmpty();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsNotNullOrEmpty_AndObjectWithFalseResultAndEmptyList_ReturnsFalse()
        {
            var emptyList = Enumerable.Empty<DummyClass>();
            var andCondition = new And<IEnumerable<DummyClass>>(emptyList, false);

            var result = andCondition.IsNotNullOrEmpty();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void IsNotNullOrEmpty_AndObjectWithFalseResultAndNotNullOrEmptyList_ReturnsFalse()
        {
            var emptyList = new List<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(emptyList, false);

            var result = andCondition.IsNotNullOrEmpty();

            result.Result.ShouldBe(false);
        }
    }
}
