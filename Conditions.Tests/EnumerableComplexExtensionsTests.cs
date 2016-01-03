using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Shouldly;
using Xunit;

namespace Conditions.Tests
{
    public class EnumerableComplexExtensionsTests
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

        [Fact]
        public void HasExactlyOneItem_AndObjectWithTrueResultAndOneItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasExactlyOneItem();

            result.Result.ShouldBe(true);
        }

        [Fact]
        public void HasExactlyOneItem_AndObjectWithTrueResultAndTwoItemList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasExactlyOneItem();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasExactlyOneItem_AndObjectWithTrueResultAndFourItemList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasExactlyOneItem();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasExactlyOneItem_AndObjectWithTrueResultAndOneItemCollection_ReturnsTrue()
        {
            var list = new Collection<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasExactlyOneItem();

            result.Result.ShouldBe(true);
        }

        [Fact]
        public void HasExactlyOneItem_AndObjectWithTrueResultAndTwoItemCollection_ReturnsFalse()
        {
            var list = new Collection<DummyClass> { new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasExactlyOneItem();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasExactlyOneItem_AndObjectWithTrueResultAndSixItemCollection_ReturnsFalse()
        {
            var list = new Collection<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasExactlyOneItem();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasExactlyOneItem_AndObjectWithFalseResultAndOneItemList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasExactlyOneItem();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasExactlyOneItem_AndObjectWithFalseResultAndTwoItemList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasExactlyOneItem();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasExactlyOneItem_AndObjectWithFalseResultAndFourItemList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasExactlyOneItem();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasExactlyOneItem_AndObjectWithFalseResultAndOneItemCollection_ReturnsFalse()
        {
            var list = new Collection<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasExactlyOneItem();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasExactlyOneItem_AndObjectWithFalseResultAndTwoItemCollection_ReturnsFalse()
        {
            var list = new Collection<DummyClass> { new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasExactlyOneItem();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasExactlyOneItem_AndObjectWithFalseResultAndSixItemCollection_ReturnsFalse()
        {
            var list = new Collection<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasExactlyOneItem();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasMoreThanOneItem_AndObjectWithTrueResultAndOneItemList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasMoreThanOneItem();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasMoreThanOneItem_AndObjectWithTrueResultAndTwoItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasMoreThanOneItem();

            result.Result.ShouldBe(true);
        }

        [Fact]
        public void HasMoreThanOneItem_AndObjectWithTrueResultAndFourItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasMoreThanOneItem();

            result.Result.ShouldBe(true);
        }

        [Fact]
        public void HasMoreThanOneItem_AndObjectWithFalseResultAndOneItemList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasMoreThanOneItem();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasMoreThanOneItem_AndObjectWithFalseResultAndTwoItemList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasMoreThanOneItem();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasMoreThanOneItem_AndObjectWithFalseResultAndFourItemList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasMoreThanOneItem();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasAtLeastOneItem_AndObjectWithTrueResultAndEmptyList_ReturnsFalse()
        {
            var list = new List<DummyClass>();
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasAtLeastOneItem();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasAtLeastOneItem_AndObjectWithTrueResultAndOneItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasAtLeastOneItem();

            result.Result.ShouldBe(true);
        }

        [Fact]
        public void HasAtLeastOneItem_AndObjectWithTrueResultAndTwoItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasAtLeastOneItem();

            result.Result.ShouldBe(true);
        }

        [Fact]
        public void HasAtLeastOneItem_AndObjectWithTrueResultAndFourItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasAtLeastOneItem();

            result.Result.ShouldBe(true);
        }

        [Fact]
        public void HasAtLeastOneItem_AndObjectWithFalseResultAndEmptyList_ReturnsFalse()
        {
            var list = new List<DummyClass>();
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasAtLeastOneItem();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasAtLeastOneItem_AndObjectWithFalseResultAndOneItemList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasAtLeastOneItem();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasAtLeastOneItem_AndObjectWithFalseResultAndTwoItemList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasAtLeastOneItem();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasAtLeastOneItem_AndObjectWithFalseResultAndFourItemList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasAtLeastOneItem();

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasItemsCount_AndObjectWithTrueResultAndOneItemListExpectedNumber_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasItemsCount(1);

            result.Result.ShouldBe(true);
        }

        [Fact]
        public void HasItemsCount_AndObjectWithTrueResultAndTwoItemLisExpectedNumber_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasItemsCount(2);

            result.Result.ShouldBe(true);
        }

        [Fact]
        public void HasItemsCount_AndObjectWithTrueResultAndFourItemListExpectedNumber_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasItemsCount(4);

            result.Result.ShouldBe(true);
        }

        [Fact]
        public void HasItemsCount_AndObjectWithTrueResultAndOneItemListUnExpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasItemsCount(2);

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasItemsCount_AndObjectWithTrueResultAndTwoItemListUnexpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasItemsCount(22);

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasItemsCount_AndObjectWithFalseResultAndFourItemListUnexpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasItemsCount(12);

            result.Result.ShouldBe(false);
        }


        [Fact]
        public void HasItemsCount_AndObjectWithFalseResultAndOneItemListExpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasItemsCount(1);

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasItemsCount_AndObjectWithFalseResultAndTwoItemLisExpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasItemsCount(2);

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasItemsCount_AndObjectWithFalseResultAndFourItemListExpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasItemsCount(4);

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasItemsCount_AndObjectWithFalseResultAndOneItemListUnExpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasItemsCount(2);

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasItemsCount_AndObjectWithFalseResultAndTwoItemListUnexpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasItemsCount(22);

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasItemsCountAtLeast_AndObjectWithTrueResultAndOneItemExpectedNumber_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasItemsCountAtLeast(1);

            result.Result.ShouldBe(true);
        }

        [Fact]
        public void HasItemsCountAtLeast_AndObjectWithTrueResultAndOneItemUnexpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasItemsCountAtLeast(2);

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasItemsCountAtLeast_AndObjectWithTrueResultAndThreeItemsExpectedNumber_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasItemsCountAtLeast(2);

            result.Result.ShouldBe(true);
        }

        [Fact]
        public void HasItemsCountAtLeast_AndObjectWithTrueResultAndThreeItemsUnexpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasItemsCountAtLeast(4);

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasItemsCountAtLeast_AndObjectWithFalseResultAndOneItemExpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasItemsCountAtLeast(1);

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasItemsCountAtLeast_AndObjectWithFalseResultAndOneItemUnexpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasItemsCountAtLeast(2);

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasItemsCountAtLeast_AndObjectWithFalseResultAndThreeItemsExpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasItemsCountAtLeast(2);

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasItemsCountAtLeast_AndObjectWithFalseResultAndThreeItemsUnexpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasItemsCountAtLeast(4);

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasMoreItemsThan_AndObjectWithTrueResultAndTwoItemsListExpectedMoreThanOneItem_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasMoreItemsThan(1);

            result.Result.ShouldBe(true);
        }

        [Fact]
        public void HasMoreItemsThan_AndObjectWithTrueResultAndTwoItemsListExpectedMoreThanTwoItem_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasMoreItemsThan(2);

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasMoreItemsThan_AndObjectWithTrueResultAndThreeItemsListExpectedMoreThanFiveItem_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, true);

            var result = andCondition.HasMoreItemsThan(5);

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasMoreItemsThan_AndObjectWithFalseResultAndTwoItemsListExpectedMoreThanOneItem_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasMoreItemsThan(1);

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasMoreItemsThan_AndObjectWithFalseResultAndTwoItemsListExpectedMoreThanTwoItem_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasMoreItemsThan(2);

            result.Result.ShouldBe(false);
        }

        [Fact]
        public void HasMoreItemsThan_AndObjectWithFalseResultAndThreeItemsListExpectedMoreThanFiveItem_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass() };
            var andCondition = new And<IEnumerable<DummyClass>>(list, false);

            var result = andCondition.HasMoreItemsThan(5);

            result.Result.ShouldBe(false);
        }
    }
}
