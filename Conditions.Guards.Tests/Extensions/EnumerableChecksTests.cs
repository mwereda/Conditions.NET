using System;
using System.Collections.Generic;
using Xunit;

namespace Conditions.Guards.Tests.Extensions
{
    public class EnumerableChecksTests
    {
        [Fact]
        public void IsEmptyList_NotEmptyCollection_ThrowArgumentException()
        {
            var list = new List<DummyClass> { new DummyClass() };

            Assert.Throws<ArgumentException>(()=> Check.If(list).IsEmpty());
        }

        [Fact]
        public void IsEmptyIList_NotEmptyCollection_ThrowArgumentException()
        {
            IList<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Assert.Throws<ArgumentException>(() => Check.If(list).IsEmpty());
        }

        [Fact]
        public void IsEmptyIEnumerable_NotEmptyCollection_ThrowArgumentException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Assert.Throws<ArgumentException>(() => Check.If(list).IsEmpty());
        }

        [Fact]
        public void IsEmptyICollection_NotEmptyCollection_ThrowArgumentException()
        {
            ICollection<DummyClass> list = new List<DummyClass> { new DummyClass() };

            Assert.Throws<ArgumentException>(() => Check.If(list).IsEmpty());
        }

        [Fact]
        public void IsNotEmptyList_EmptyCollection_ThrowArgumentException()
        {
            var list = new List<DummyClass>();

            Assert.Throws<ArgumentException>(() => Check.If(list).IsNotEmpty());
        }

        [Fact]
        public void IsNotEmptyIList_EmptyCollection_ThrowArgumentException()
        {
            IList<DummyClass> list = new List<DummyClass>();

            Assert.Throws<ArgumentException>(() => Check.If(list).IsNotEmpty());
        }

        [Fact]
        public void IsNotEmptyIEnumerable_EmptyCollection_ThrowArgumentException()
        {
            IEnumerable<DummyClass> list = new List<DummyClass>();

            Assert.Throws<ArgumentException>(() => Check.If(list).IsNotEmpty());
        }

        [Fact]
        public void IsNotEmptyICollection_EmptyCollection_ThrowArgumentException()
        {
            ICollection<DummyClass> list = new List<DummyClass>();

            Assert.Throws<ArgumentException>(() => Check.If(list).IsNotEmpty());
        }
    }
}
