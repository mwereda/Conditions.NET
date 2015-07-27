﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xunit;

namespace Conditions.Tests
{
    public class EnumerableExtensionsTests
    {
        [Fact]
        public void HasExactlyOneItem_OneItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass() };

            Assert.True(list.HasExactlyOneItem());
        }

        [Fact]
        public void HasExactlyOneItem_TwoItemList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Assert.False(list.HasExactlyOneItem());
        }

        [Fact]
        public void HasExactlyOneItem_FourItemList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };

            Assert.False(list.HasExactlyOneItem());
        }

        [Fact]
        public void HasExactlyOneItem_OneItemCollection_ReturnsTrue()
        {
            var list = new Collection<DummyClass> { new DummyClass() };

            Assert.True(list.HasExactlyOneItem());
        }

        [Fact]
        public void HasExactlyOneItem_TwoItemCollection_ReturnsFalse()
        {
            var list = new Collection<DummyClass> { new DummyClass(), new DummyClass() };

            Assert.False(list.HasExactlyOneItem());
        }

        [Fact]
        public void HasExactlyOneItem_SixItemCollection_ReturnsFalse()
        {
            var list = new Collection<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };

            Assert.False(list.HasExactlyOneItem());
        }

        [Fact]
        public void HasMoreThanOneItem_OneItemList_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };

            Assert.False(list.HasMoreThanOneItem());
        }

        [Fact]
        public void HasMoreThanOneItem_TwoItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Assert.True(list.HasMoreThanOneItem());
        }

        [Fact]
        public void HasMoreThanOneItem_FourItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };

            Assert.True(list.HasMoreThanOneItem());
        }

        [Fact]
        public void HasAtLeastOneItem_EmptyList_ReturnsFalse()
        {
            var list = new List<DummyClass>();

            Assert.False(list.HasAtLeastOneItem());
        }

        [Fact]
        public void HasAtLeastOneItem_OneItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass() };

            Assert.True(list.HasAtLeastOneItem());
        }

        [Fact]
        public void HasAtLeastOneItem_TwoItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Assert.True(list.HasAtLeastOneItem());
        }

        [Fact]
        public void HasAtLeastOneItem_FourItemList_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };

            Assert.True(list.HasAtLeastOneItem());
        }

        [Fact]
        public void HasItemsCount_OneItemListExpectedNumber_ReturnsTrue()
        {
            var list = new List<DummyClass> { new DummyClass() };

            Assert.True(list.HasItemsCount(1));
        }

        [Fact]
        public void HasItemsCount_TwoItemLisExpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Assert.True(list.HasItemsCount(2));
        }

        [Fact]
        public void HasItemsCount_FourItemListExpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };

            Assert.True(list.HasItemsCount(4));
        }

        [Fact]
        public void HasItemsCount_OneItemListUnExpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass() };

            Assert.False(list.HasItemsCount(2));
        }

        [Fact]
        public void HasItemsCount_TwoItemListUnexpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Assert.False(list.HasItemsCount(34));
        }

        [Fact]
        public void HasItemsCount_FourItemListUnexpectedNumber_ReturnsFalse()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass(), new DummyClass() };

            Assert.False(list.HasItemsCount(14));
        }
    }
}