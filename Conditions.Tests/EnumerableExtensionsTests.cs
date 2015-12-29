using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Shouldly;
using Xunit;

namespace Conditions.Tests
{
    public class EnumerableExtensionsTests
    {
        [Fact]
        public void IsEmpty_EmptyList_ReturnsTrue()
        {
            var list = new List<DummyClass>();

            list.IsEmpty().Result.ShouldBe(true);
        }

        [Fact]
        public void IsEmpty_NotEmptyList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };

            list.IsEmpty().Result.ShouldBe(false);
        }

        [Fact]
        public void IsNullOrEmpty_NullList_ReturnsTrue()
        {
            List<DummyClass> nullList = null;

            nullList.IsNullOrEmpty().Result.ShouldBe(true);
        }

        [Fact]
        public void IsNullOrEmpty_EmptyList_ReturnsTrue()
        {
            var emptyList = Enumerable.Empty<DummyClass>();

            emptyList.IsNullOrEmpty().Result.ShouldBe(true);
        }

        [Fact]
        public void IsNullOrEmpty_NotNullOrEmptyList_ReturnsFalse()
        {
            var emptyList = new List<DummyClass> { new DummyClass() };

            emptyList.IsNullOrEmpty().Result.ShouldBe(false);
        }

        [Fact]
        public void IsNotNullOrEmpty_NullList_ReturnsFalse()
        {
            List<DummyClass> nullList = null;

            nullList.IsNotNullOrEmpty().Result.ShouldBe(false);
        }

        [Fact]
        public void IsNotNullOrEmpty_EmptyList_ReturnsFalse()
        {
            var emptyList = Enumerable.Empty<DummyClass>();

            emptyList.IsNotNullOrEmpty().Result.ShouldBe(false);
        }

        [Fact]
        public void IsNotNullOrEmpty_NotNullOrEmptyList_ReturnsTrue()
        {
            var emptyList = new List<DummyClass> { new DummyClass() };

            emptyList.IsNotNullOrEmpty().Result.ShouldBe(true);
        }

        [Fact]
        public void HasExactlyOneItem_OneItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass() };

            list.HasExactlyOneItem().Result.ShouldBe(true);
        }

        [Fact]
        public void HasExactlyOneItem_TwoItemList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            list.HasExactlyOneItem().Result.ShouldBe(false);
        }

        [Fact]
        public void HasExactlyOneItem_FourItemList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };

            list.HasExactlyOneItem().Result.ShouldBe(false);
        }

        [Fact]
        public void HasExactlyOneItem_OneItemCollection_ReturnsTrue()
        {
            var list = new Collection<DummyClass> { new DummyClass() };

            list.HasExactlyOneItem().Result.ShouldBe(true);
        }

        [Fact]
        public void HasExactlyOneItem_TwoItemCollection_ReturnsFalse()
        {
            var list = new Collection<DummyClass> { new DummyClass(), new DummyClass() };

            list.HasExactlyOneItem().Result.ShouldBe(false);
        }

        [Fact]
        public void HasExactlyOneItem_SixItemCollection_ReturnsFalse()
        {
            var list = new Collection<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };

            list.HasExactlyOneItem().Result.ShouldBe(false);
        }

        [Fact]
        public void HasMoreThanOneItem_OneItemList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };

            list.HasMoreThanOneItem().Result.ShouldBe(false);
        }

        [Fact]
        public void HasMoreThanOneItem_TwoItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            list.HasMoreThanOneItem().Result.ShouldBe(true);
        }

        [Fact]
        public void HasMoreThanOneItem_FourItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };

            list.HasMoreThanOneItem().Result.ShouldBe(true);
        }

        [Fact]
        public void HasAtLeastOneItem_EmptyList_ReturnsFalse()
        {
            var list = new List<DummyClass>();

            list.HasAtLeastOneItem().Result.ShouldBe(false);
        }

        [Fact]
        public void HasAtLeastOneItem_OneItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass() };

            list.HasAtLeastOneItem().Result.ShouldBe(true);
        }

        [Fact]
        public void HasAtLeastOneItem_TwoItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            list.HasAtLeastOneItem().Result.ShouldBe(true);
        }

        [Fact]
        public void HasAtLeastOneItem_FourItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };

            list.HasAtLeastOneItem().Result.ShouldBe(true);
        }

        [Fact]
        public void HasItemsCount_OneItemListExpectedNumber_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass() };

            list.HasItemsCount(1).Result.ShouldBe(true);
        }

        [Fact]
        public void HasItemsCount_TwoItemLisExpectedNumber_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            list.HasItemsCount(2).Result.ShouldBe(true);
        }

        [Fact]
        public void HasItemsCount_FourItemListExpectedNumber_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };

            list.HasItemsCount(4).Result.ShouldBe(true);
        }

        [Fact]
        public void HasItemsCount_OneItemListUnExpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };

            list.HasItemsCount(2).Result.ShouldBe(false);
        }

        [Fact]
        public void HasItemsCount_TwoItemListUnexpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            list.HasItemsCount(34).Result.ShouldBe(false);
        }

        [Fact]
        public void HasItemsCount_FourItemListUnexpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };

            list.HasItemsCount(14).Result.ShouldBe(false);
        }

        [Fact]
        public void HasItemsCountAtLeast_OneItemExpectedNumber_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass() };

            list.HasItemsCountAtLeast(1).Result.ShouldBe(true);
        }

        [Fact]
        public void HasItemsCountAtLeast_OneItemUnexpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };

            list.HasItemsCountAtLeast(2).Result.ShouldBe(false);
        }

        [Fact]
        public void HasItemsCountAtLeast_ThreeItemsExpectedNumber_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass() };

            list.HasItemsCountAtLeast(2).Result.ShouldBe(true);
        }

        [Fact]
        public void HasItemsCountAtLeast_ThreeItemsUnexpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass() };

            list.HasItemsCountAtLeast(4).Result.ShouldBe(false);
        }

        [Fact]
        public void HasMoreItemsThan_TwoItemsListExpectedMoreThanOneItem_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            list.HasMoreItemsThan(1).Result.ShouldBe(true);
        }

        [Fact]
        public void HasMoreItemsThan_TwoItemsListExpectedMoreThanTwoItem_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            list.HasMoreItemsThan(2).Result.ShouldBe(false);
        }

        [Fact]
        public void HasMoreItemsThan_ThreeItemsListExpectedMoreThanFiveItem_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass() };

            list.HasMoreItemsThan(5).Result.ShouldBe(false);
        }
    }
}
