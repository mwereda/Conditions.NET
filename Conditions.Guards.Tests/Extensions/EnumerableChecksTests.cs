using System;
using System.Collections.Generic;
using Shouldly;
using Xunit;

namespace Conditions.Guards.Tests.Extensions
{
    public class EnumerableChecksTests
    {
        [Fact]
        public void IsEmptyList_NotEmptyCollection_ThrowArgumentException()
        {
            var list = new List<DummyClass> { new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).IsEmpty());
        }

        [Fact]
        public void IsEmptyIList_NotEmptyCollection_ThrowArgumentException()
        {
            IList<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).IsEmpty());
        }

        [Fact]
        public void IsEmptyIEnumerable_NotEmptyCollection_ThrowArgumentException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).IsEmpty());
        }

        [Fact]
        public void IsEmptyICollection_NotEmptyCollection_ThrowArgumentException()
        {
            ICollection<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).IsEmpty());
        }

        [Fact]
        public void IsEmptyList_NotEmptyCollectionDummyExceptionConfigured_ThrowDummyException()
        {
            var list = new List<DummyClass> { new DummyClass() };

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFail<DummyException>().If(list).IsEmpty());
        }

        [Fact]
        public void IsEmptyIList_NotEmptyCollectionDivideByZeroExceptionConfigured_ThrowDividedByZeroException()
        {
            IList<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<DivideByZeroException>(() => Check.AndThrowThisWhenFail<DivideByZeroException>().If(list).IsEmpty());
        }

        [Fact]
        public void IsEmptyIEnumerable_NotEmptyCollectionInvalidOperationExceptionConfigured_ThrowInvalidOperationException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFail<InvalidOperationException>().If(list).IsEmpty());
        }

        [Fact]
        public void IsEmptyICollection_NotEmptyCollectionInvalidCastExceptionConfigured_ThrowInvalidCastException()
        {
            ICollection<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<InvalidCastException>(() => Check.AndThrowThisWhenFail<InvalidCastException>().If(list).IsEmpty());
        }

        [Fact]
        public void IsEmptyList_NotEmptyCollectionDummyExceptionConfiguredWithFactory_ThrowDummyException()
        {
            var list = new List<DummyClass> { new DummyClass() };

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFail(() => new DummyException()).If(list).IsEmpty());
        }

        [Fact]
        public void IsEmptyIList_NotEmptyCollectionDivideByZeroExceptionConfiguredWithFactory_ThrowDividedByZeroException()
        {
            IList<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<DivideByZeroException>(() => Check.AndThrowThisWhenFail(() => new DivideByZeroException()).If(list).IsEmpty());
        }

        [Fact]
        public void IsEmptyIEnumerable_NotEmptyCollectionInvalidOperationExceptionConfiguredWithFactory_ThrowInvalidOperationException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFail(() => new InvalidOperationException()).If(list).IsEmpty());
        }

        [Fact]
        public void IsEmptyICollection_NotEmptyCollectionInvalidCastExceptionConfiguredWithFactory_ThrowInvalidCastException()
        {
            ICollection<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<InvalidCastException>(() => Check.AndThrowThisWhenFail(() => new InvalidCastException()).If(list).IsEmpty());
        }

        [Fact]
        public void IsNotEmptyList_EmptyCollection_ThrowArgumentException()
        {
            var list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).IsNotEmpty());
        }

        [Fact]
        public void IsNotEmptyIList_EmptyCollection_ThrowArgumentException()
        {
            IList<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).IsNotEmpty());
        }

        [Fact]
        public void IsNotEmptyIEnumerable_EmptyCollection_ThrowArgumentException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).IsNotEmpty());
        }

        [Fact]
        public void IsNotEmptyICollection_EmptyCollection_ThrowArgumentException()
        {
            ICollection<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).IsNotEmpty());
        }

        [Fact]
        public void IsNotEmptyList_EmptyCollectionInvalidOperationExceptionConfigured_ThrowInvalidOperationException()
        {
            var list = new List<DummyClass>();

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFail<InvalidOperationException>().If(list).IsNotEmpty());
        }

        [Fact]
        public void IsNotEmptyIList_EmptyCollectionDummyExceptionConfigured_ThrowDummyException()
        {
            IList<DummyClass> list = new List<DummyClass>();

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFail<DummyException>().If(list).IsNotEmpty());
        }

        [Fact]
        public void IsNotEmptyIEnumerable_EmptyCollectionInvalidTimeZoneExceptionConfigured_ThrowInvalidTimeZoneException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass>();

            Should.Throw<InvalidTimeZoneException>(() => Check.AndThrowThisWhenFail<InvalidTimeZoneException>().If(list).IsNotEmpty());
        }

        [Fact]
        public void IsNotEmptyICollection_EmptyCollectionNullReferenceExceptionConfigured_ThrowNullReferenceException()
        {
            ICollection<DummyClass> list = new List<DummyClass>();

            Should.Throw<NullReferenceException>(() => Check.AndThrowThisWhenFail<NullReferenceException>().If(list).IsNotEmpty());
        }

        [Fact]
        public void HasExactlyOneItemList_EmptyCollection_ThrowArgumentException()
        {
            var list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasExactlyOneItem());
        }

        [Fact]
        public void HasExactlyOneItemList_MoreThanOneItemInCollection_ThrowArgumentException()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasExactlyOneItem());
        }

        [Fact]
        public void HasExactlyOneItemIList_EmptyCollection_ThrowArgumentException()
        {
            IList<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasExactlyOneItem());
        }

        [Fact]
        public void HasExactlyOneItemIList_MoreThanOneItemInCollection_ThrowArgumentException()
        {
            IList<DummyClass> list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasExactlyOneItem());
        }

        [Fact]
        public void HasExactlyOneItemIEnumerable_EmptyCollection_ThrowArgumentException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasExactlyOneItem());
        }

        [Fact]
        public void HasExactlyOneItemIEnumerable_MoreThanOneItemInCollection_ThrowArgumentException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasExactlyOneItem());
        }

        [Fact]
        public void HasExactlyOneItemICollection_EmptyCollection_ThrowArgumentException()
        {
            ICollection<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasExactlyOneItem());
        }

        [Fact]
        public void HasExactlyOneItemICollection_MoreThanOneItemInCollection_ThrowArgumentException()
        {
            ICollection<DummyClass> list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasExactlyOneItem());
        }

        [Fact]
        public void HasExactlyOneItemList_EmptyCollectionInvalidOperationExceptionConfigured_ThrowInvalidOperationException()
        {
            var list = new List<DummyClass>();

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFail<InvalidOperationException>().If(list).HasExactlyOneItem());
        }

        [Fact]
        public void HasExactlyOneItemIList_MoreThanOneItemInCollectionDummyExceptionConfigured_ThrowDummyException()
        {
            IList<DummyClass> list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFail<DummyException>().If(list).HasExactlyOneItem());
        }

        [Fact]
        public void HasExactlyOneItemIEnumerable_EmptyCollectionInvalidCastExceptionConfigured_ThrowInvalidCastException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass>();

            Should.Throw<InvalidCastException>(() => Check.AndThrowThisWhenFail<InvalidCastException>().If(list).HasExactlyOneItem());
        }

        [Fact]
        public void HasExactlyOneItemICollection_MoreThanOneItemInCollectionNullReferenceException_ThrowNullReferenceException()
        {
            ICollection<DummyClass> list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Should.Throw<NullReferenceException>(() => Check.AndThrowThisWhenFail<NullReferenceException>().If(list).HasExactlyOneItem());
        }

        [Fact]
        public void HasExactlyOneItemList_EmptyCollectionInvalidOperationExceptionConfiguredWithFactory_ThrowInvalidOperationException()
        {
            var list = new List<DummyClass>();

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFail(() => new InvalidOperationException()).If(list).HasExactlyOneItem());
        }

        [Fact]
        public void HasExactlyOneItemIList_MoreThanOneItemInCollectionDummyExceptionConfiguredWithFactory_ThrowDummyException()
        {
            IList<DummyClass> list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFail(() => new DummyException()).If(list).HasExactlyOneItem());
        }

        [Fact]
        public void HasExactlyOneItemIEnumerable_EmptyCollectionInvalidCastExceptionConfiguredWithFactory_ThrowInvalidCastException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass>();

            Should.Throw<InvalidCastException>(() => Check.AndThrowThisWhenFail(() => new InvalidCastException()).If(list).HasExactlyOneItem());
        }

        [Fact]
        public void HasExactlyOneItemICollection_MoreThanOneItemInCollectionNullReferenceExceptionConfiguredWithFactory_ThrowNullReferenceException()
        {
            ICollection<DummyClass> list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Should.Throw<NullReferenceException>(() => Check.AndThrowThisWhenFail(() => new NullReferenceException()).If(list).HasExactlyOneItem());
        }

        [Fact]
        public void HasMoreThanOneItemList_EmptyCollection_ThrowArgumentException()
        {
            var list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreThanOneItem());
        }

        [Fact]
        public void HasMoreThanOneItemList_OneItemInCollection_ThrowArgumentException()
        {
            var list = new List<DummyClass> { new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreThanOneItem());
        }

        [Fact]
        public void HasMoreThanOneItemIList_EmptyCollection_ThrowArgumentException()
        {
            IList<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreThanOneItem());
        }

        [Fact]
        public void HasMoreThanOneItemIList_OneItemInCollection_ThrowArgumentException()
        {
            IList<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreThanOneItem());
        }

        [Fact]
        public void HasMoreThanOneItemIEnumerable_EmptyCollection_ThrowArgumentException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreThanOneItem());
        }

        [Fact]
        public void HasMoreThanOneItemIEnumerable_OneItemInCollection_ThrowArgumentException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreThanOneItem());
        }

        [Fact]
        public void HasMoreThanOneItemICollection_EmptyCollection_ThrowArgumentException()
        {
            ICollection<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreThanOneItem());
        }

        [Fact]
        public void HasMoreThanOneItemICollection_OneItemInCollection_ThrowArgumentException()
        {
            ICollection<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreThanOneItem());
        }

        [Fact]
        public void HasMoreThanOneItemList_OneItemInCollectionInvalidOperationExceptionConfigured_ThrowInvalidOperationException()
        {
            var list = new List<DummyClass> { new DummyClass() };

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFail<InvalidOperationException>().If(list).HasMoreThanOneItem());
        }

        [Fact]
        public void HasMoreThanOneItemIList_EmptyCollectionDummyExceptionConfigured_ThrowDummyException()
        {
            IList<DummyClass> list = new List<DummyClass>();

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFail<DummyException>().If(list).HasMoreThanOneItem());
        }

        [Fact]
        public void HasMoreThanOneItemIEnumerable_OneItemInCollectionInvalidCastExceptionConfigured_ThrowInvalidCastException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<InvalidCastException>(() => Check.AndThrowThisWhenFail<InvalidCastException>().If(list).HasMoreThanOneItem());
        }

        [Fact]
        public void HasMoreThanOneItemICollection_OneItemInCollectionDividedByZeroExceptionConfigured_ThrowDividedByZeroException()
        {
            ICollection<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<DivideByZeroException>(() => Check.AndThrowThisWhenFail<DivideByZeroException>().If(list).HasMoreThanOneItem());
        }

        [Fact]
        public void HasMoreThanOneItemList_OneItemInCollectionInvalidOperationExceptionConfiguredWithFactory_ThrowInvalidOperationException()
        {
            var list = new List<DummyClass> { new DummyClass() };

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFail(() => new InvalidOperationException()).If(list).HasMoreThanOneItem());
        }

        [Fact]
        public void HasMoreThanOneItemIList_EmptyCollectionDummyExceptionConfiguredWithFactory_ThrowDummyException()
        {
            IList<DummyClass> list = new List<DummyClass>();

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFail(() => new DummyException()).If(list).HasMoreThanOneItem());
        }

        [Fact]
        public void HasMoreThanOneItemIEnumerable_OneItemInCollectionInvalidCastExceptionConfiguredWithFactory_ThrowInvalidCastException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<InvalidCastException>(() => Check.AndThrowThisWhenFail(() => new InvalidCastException()).If(list).HasMoreThanOneItem());
        }

        [Fact]
        public void HasMoreThanOneItemICollection_OneItemInCollectionDividedByZeroExceptionConfiguredWithFactory_ThrowDividedByZeroException()
        {
            ICollection<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<DivideByZeroException>(() => Check.AndThrowThisWhenFail(() => new DivideByZeroException()).If(list).HasMoreThanOneItem());
        }

        [Fact]
        public void HasAtLeastOneItemList_EmptyCollection_ThrowArgumentException()
        {
            var list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasAtLeastOneItem());
        }

        [Fact]
        public void HasAtLeastOneItemIList_EmptyCollection_ThrowArgumentException()
        {
            IList<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasAtLeastOneItem());
        }

        [Fact]
        public void HasAtLeastOneItemIEnumerable_EmptyCollection_ThrowArgumentException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasAtLeastOneItem());
        }

        [Fact]
        public void HasAtLeastOneItemICollection_EmptyCollection_ThrowArgumentException()
        {
            ICollection<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasAtLeastOneItem());
        }

        [Fact]
        public void HasAtLeastOneItemList_EmptyCollectionArgumentNullExceptionConfigured_ThrowArgumentNullException()
        {
            var list = new List<DummyClass>();

            Should.Throw<ArgumentNullException>(() => Check.AndThrowThisWhenFail<ArgumentNullException>().If(list).HasAtLeastOneItem());
        }

        [Fact]
        public void HasAtLeastOneItemIList_EmptyCollectionNullReferenceExceptionConfigured_ThrowNullReferenceException()
        {
            IList<DummyClass> list = new List<DummyClass>();

            Should.Throw<NullReferenceException>(() => Check.AndThrowThisWhenFail<NullReferenceException>().If(list).HasAtLeastOneItem());
        }

        [Fact]
        public void HasAtLeastOneItemIEnumerable_EmptyCollectionDummyExceptionConfigured_ThrowDummyException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass>();

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFail<DummyException>().If(list).HasAtLeastOneItem());
        }

        [Fact]
        public void HasAtLeastOneItemICollection_EmptyCollectionInvalidOperationExceptionConfigured_ThrowInvalidOperationException()
        {
            ICollection<DummyClass> list = new List<DummyClass>();

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFail<InvalidOperationException>().If(list).HasAtLeastOneItem());
        }

        [Fact]
        public void HasAtLeastOneItemList_EmptyCollectionArgumentNullExceptionConfiguredWithFactory_ThrowArgumentNullException()
        {
            var list = new List<DummyClass>();

            Should.Throw<ArgumentNullException>(() => Check.AndThrowThisWhenFail(() => new ArgumentNullException()).If(list).HasAtLeastOneItem());
        }

        [Fact]
        public void HasAtLeastOneItemIList_EmptyCollectionNullReferenceExceptionConfiguredWithFactory_ThrowNullReferenceException()
        {
            IList<DummyClass> list = new List<DummyClass>();

            Should.Throw<NullReferenceException>(() => Check.AndThrowThisWhenFail(() => new NullReferenceException()).If(list).HasAtLeastOneItem());
        }

        [Fact]
        public void HasAtLeastOneItemIEnumerable_EmptyCollectionDummyExceptionConfiguredWithFactory_ThrowDummyException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass>();

            Should.Throw<DummyException>(() => Check.AndThrowThisWhenFail(() => new DummyException()).If(list).HasAtLeastOneItem());
        }

        [Fact]
        public void HasAtLeastOneItemICollection_EmptyCollectionInvalidOperationExceptionConfiguredWithFactory_ThrowInvalidOperationException()
        {
            ICollection<DummyClass> list = new List<DummyClass>();

            Should.Throw<InvalidOperationException>(() => Check.AndThrowThisWhenFail(() => new InvalidOperationException()).If(list).HasAtLeastOneItem());
        }

        [Fact]
        public void HasItemsCountList_EmptyCollectionExpectOne_ThrowArgumentException()
        {
            var list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasItemsCount(1));
        }

        [Fact]
        public void HasItemsCountList_TwoItemsInCollectionExpectOne_ThrowArgumentException()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasItemsCount(1));
        }

        [Fact]
        public void HasItemsCountList_TwoItemsInCollectionExpectThree_ThrowArgumentException()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasItemsCount(3));
        }

        [Fact]
        public void HasItemsCountIList_EmptyCollectionExpectOne_ThrowArgumentException()
        {
            IList<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasItemsCount(1));
        }

        [Fact]
        public void HasItemsCountIList_OneItemInCollectionExpectTwo_ThrowArgumentException()
        {
            IList<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasItemsCount(2));
        }

        [Fact]
        public void HasItemsCountIList_OneItemInCollectionExpectZero_ThrowArgumentException()
        {
            IList<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasItemsCount(0));
        }

        [Fact]
        public void HasItemsCountIEnumerable_EmptyCollectionExpectOne_ThrowArgumentException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasItemsCount(1));
        }

        [Fact]
        public void HasItemsCountIEnumerable_ThreeItemsInCollectionExpectFour_ThrowArgumentException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasItemsCount(4));
        }

        [Fact]
        public void HasItemsCountIEnumerable_ThreeItemsInCollectionExpectTwo_ThrowArgumentException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass> { new DummyClass(), new DummyClass(), new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasItemsCount(2));
        }

        [Fact]
        public void HasItemsCountICollection_EmptyCollectionExpectOne_ThrowArgumentException()
        {
            ICollection<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasItemsCount(1));
        }

        [Fact]
        public void HasItemsCountICollection_TwoItemsInCollectionExpectOne_ThrowArgumentException()
        {
            ICollection<DummyClass> list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasItemsCount(1));
        }

        [Fact]
        public void HasItemsCountICollection_TwoItemsInCollectionExpectFour_ThrowArgumentException()
        {
            ICollection<DummyClass> list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasItemsCount(4));
        }

        [Fact]
        public void HasItemsCountAtLeastList_EmptyCollectionExpectOne_ThrowArgumentException()
        {
            var list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasItemsCountAtLeast(1));
        }

        [Fact]
        public void HasItemsCountAtLeastList_TwoItemsInCollectionExpectThree_ThrowArgumentException()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasItemsCountAtLeast(3));
        }

        [Fact]
        public void HasItemsCountAtLeastIList_EmptyCollectionExpectTwo_ThrowArgumentException()
        {
            IList<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasItemsCountAtLeast(2));
        }

        [Fact]
        public void HasItemsCountAtLeastIList_TwoItemsInCollectionExpectFour_ThrowArgumentException()
        {
            IList<DummyClass> list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasItemsCountAtLeast(4));
        }

        [Fact]
        public void HasItemsCountAtLeastIEnumerable_EmptyCollectionExpectTen_ThrowArgumentException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasItemsCountAtLeast(10));
        }

        [Fact]
        public void HasItemsCountAtLeastIEnumerable_OneItemInCollectionExpectTwo_ThrowArgumentException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasItemsCountAtLeast(2));
        }

        [Fact]
        public void HasItemsCountAtLeastICollection_EmptyCollectionExpectTwo_ThrowArgumentException()
        {
            ICollection<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasItemsCountAtLeast(2));
        }

        [Fact]
        public void HasItemsCountAtLeastICollection_OneItemInCollectionExpectFive_ThrowArgumentException()
        {
            ICollection<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasItemsCountAtLeast(5));
        }

        [Fact]
        public void HasMoreItemsThanList_EmptyCollectionExpectMoreThanOne_ThrowArgumentException()
        {
            var list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreItemsThan(1));
        }

        [Fact]
        public void HasMoreItemsThanList_EmptyCollectionExpectMoreThanZero_ThrowArgumentException()
        {
            var list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreItemsThan(0));
        }

        [Fact]
        public void HasMoreItemsThanList_TwoItemsInCollectionExpectMoreThanThree_ThrowArgumentException()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreItemsThan(3));
        }

        [Fact]
        public void HasMoreItemsThanList_TwoItemsInCollectionExpectMoreThanTwo_ThrowArgumentException()
        {
            var list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreItemsThan(2));
        }

        [Fact]
        public void HasMoreItemsThanIList_EmptyCollectionExpectMoreThanTwo_ThrowArgumentException()
        {
            IList<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreItemsThan(2));
        }

        [Fact]
        public void HasMoreItemsThanIList_EmptyCollectionExpectMoreThanZero_ThrowArgumentException()
        {
            IList<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreItemsThan(0));
        }

        [Fact]
        public void HasMoreItemsThanIList_TwoItemsInCollectionExpectMoreThanFour_ThrowArgumentException()
        {
            IList<DummyClass> list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreItemsThan(4));
        }

        [Fact]
        public void HasMoreItemsThanIList_TwoItemsInCollectionExpectMoreThanTwo_ThrowArgumentException()
        {
            IList<DummyClass> list = new List<DummyClass> { new DummyClass(), new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreItemsThan(2));
        }

        [Fact]
        public void HasMoreItemsThanIEnumerable_EmptyCollectionExpectMoreThanTen_ThrowArgumentException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreItemsThan(10));
        }

        [Fact]
        public void HasMoreItemsThanIEnumerable_EmptyCollectionExpectMoreThanZero_ThrowArgumentException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreItemsThan(0));
        }

        [Fact]
        public void HasMoreItemsThanIEnumerable_OneItemInCollectionExpectMoreThanTwo_ThrowArgumentException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreItemsThan(2));
        }

        [Fact]
        public void HasMoreItemsThanIEnumerable_OneItemInCollectionExpectMoreThanOne_ThrowArgumentException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreItemsThan(1));
        }

        [Fact]
        public void HasMoreItemsThanICollection_EmptyCollectionExpectMoreThanTwo_ThrowArgumentException()
        {
            ICollection<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreItemsThan(2));
        }

        [Fact]
        public void HasMoreItemsThanICollection_EmptyCollectionExpectMoreThanZero_ThrowArgumentException()
        {
            ICollection<DummyClass> list = new List<DummyClass>();

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreItemsThan(0));
        }

        [Fact]
        public void HasMoreItemsThanICollection_OneItemInCollectionExpectMoreThanFive_ThrowArgumentException()
        {
            ICollection<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreItemsThan(5));
        }

        [Fact]
        public void HasMoreItemsThanICollection_OneItemInCollectionExpectMoreThanOne_ThrowArgumentException()
        {
            ICollection<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Should.Throw<ArgumentException>(() => Check.If(list).HasMoreItemsThan(1));
        }
    }
}
