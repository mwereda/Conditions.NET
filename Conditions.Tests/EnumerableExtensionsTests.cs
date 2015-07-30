using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            list.IsEmpty().ShouldBe(true);
        }

        [Fact]
        public void IsEmpty_NotEmptyList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };

            list.IsEmpty().ShouldBe(false);
        }

        [Fact]
        public void HasExactlyOneItem_OneItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass() };

            list.HasExactlyOneItem().ShouldBe(true);
        }

        [Fact]
        public void HasExactlyOneItem_TwoItemList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

			list.HasExactlyOneItem().ShouldBe(false);
        }

        [Fact]
        public void HasExactlyOneItem_FourItemList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };

            list.HasExactlyOneItem().ShouldBe(false);
        }

        [Fact]
        public void HasExactlyOneItem_OneItemCollection_ReturnsTrue()
        {
            var list = new Collection<DummyClass> { new DummyClass() };

			list.HasExactlyOneItem().ShouldBe(true);
        }

        [Fact]
        public void HasExactlyOneItem_TwoItemCollection_ReturnsFalse()
        {
            var list = new Collection<DummyClass> { new DummyClass(), new DummyClass() };

            list.HasExactlyOneItem().ShouldBe(false);
        }

        [Fact]
        public void HasExactlyOneItem_SixItemCollection_ReturnsFalse()
        {
            var list = new Collection<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };

			list.HasExactlyOneItem().ShouldBe(false);
        }

        [Fact]
        public void HasMoreThanOneItem_OneItemList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };

			list.HasMoreThanOneItem().ShouldBe(false);
        }

        [Fact]
        public void HasMoreThanOneItem_TwoItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

			list.HasMoreThanOneItem().ShouldBe(true);
        }

        [Fact]
        public void HasMoreThanOneItem_FourItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };

			list.HasMoreThanOneItem().ShouldBe(true);
        }

        [Fact]
        public void HasAtLeastOneItem_EmptyList_ReturnsFalse()
        {
            var list = new List<DummyClass>();

			list.HasAtLeastOneItem().ShouldBe(false);
        }

        [Fact]
        public void HasAtLeastOneItem_OneItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass() };

			list.HasAtLeastOneItem().ShouldBe(true);
        }

        [Fact]
        public void HasAtLeastOneItem_TwoItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

			list.HasAtLeastOneItem().ShouldBe(true);
        }

        [Fact]
        public void HasAtLeastOneItem_FourItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };

			list.HasAtLeastOneItem().ShouldBe(true);
        }

        [Fact]
        public void HasItemsCount_OneItemListExpectedNumber_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass() };

            list.HasItemsCount(1).ShouldBe(true);
        }

        [Fact]
        public void HasItemsCount_TwoItemLisExpectedNumber_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

			list.HasItemsCount(2).ShouldBe(true);
        }

        [Fact]
        public void HasItemsCount_FourItemListExpectedNumber_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };

			list.HasItemsCount(4).ShouldBe(true);
        }

        [Fact]
        public void HasItemsCount_OneItemListUnExpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };

			list.HasItemsCount(2).ShouldBe(false);
        }

        [Fact]
        public void HasItemsCount_TwoItemListUnexpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

			list.HasItemsCount(34).ShouldBe(false);
        }

        [Fact]
        public void HasItemsCount_FourItemListUnexpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };

            list.HasItemsCount(14).ShouldBe(false);
        }

        [Fact]
        public void HasItemsCountAtLeast_OneItemExpectedNumber_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass() };

			list.HasItemsCountAtLeast(1).ShouldBe(true);
        }

        [Fact]
        public void HasItemsCountAtLeast_OneItemUnexpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };

			list.HasItemsCountAtLeast(2).ShouldBe(false);
        }

        [Fact]
        public void HasItemsCountAtLeast_ThreeItemsExpectedNumber_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass() };

			list.HasItemsCountAtLeast(2).ShouldBe(true);
        }

        [Fact]
        public void HasItemsCountAtLeast_ThreeItemsUnexpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass() };

            list.HasItemsCountAtLeast(4).ShouldBe(false);
        }

        [Fact]
        public void HasMoreItemsThan_TwoItemsListExpectedMoreThanOneItem_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

			list.HasMoreItemsThan(1).ShouldBe(true);
        }

        [Fact]
        public void HasMoreItemsThan_TwoItemsListExpectedMoreThanTwoItem_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

			list.HasMoreItemsThan(2).ShouldBe(false);
        }

        [Fact]
        public void HasMoreItemsThan_ThreeItemsListExpectedMoreThanFiveItem_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass() };

			list.HasMoreItemsThan(5).ShouldBe(false);
        }
    }
}
