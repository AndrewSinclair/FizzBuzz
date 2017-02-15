using System;
using System.Collections.Generic;
using System.Linq;
using ClearMeasure;
using NUnit.Framework;

// ReSharper disable ObjectCreationAsStatement

namespace NUnitTestProject1
{
    [TestFixture]
    public class TestFizzBuzzer
    {
        private FizzBuzz _myFizzerBuzzer;
        private IEnumerable<string> _fizzBuzzes;

        private FizzBuzz _myFooBarrer;
        private IEnumerable<string> _fooBars;

        private FizzBuzz _myBaz;
        private IEnumerable<string> _bazes;

        [OneTimeSetUp]
        public void Setup()
        {
            _myFizzerBuzzer = new FizzBuzz(int.MaxValue);
            _fizzBuzzes = _myFizzerBuzzer.GetFizzBuzzNums();

            _myFooBarrer = new FizzBuzz(
                int.MaxValue,
                new List<NumberKeywordPair>
                {
                    new NumberKeywordPair {Number = 7, Keyword = "Foo"},
                    new NumberKeywordPair {Number = 11, Keyword = "Bar"}
                });
            _fooBars = _myFooBarrer.GetFizzBuzzNums();

            _myBaz = new FizzBuzz(
                int.MaxValue,
                new List<NumberKeywordPair>
                {
                    new NumberKeywordPair {Number = 97, Keyword = "Baz"}
                });

            _bazes = _myBaz.GetFizzBuzzNums();
        }

        [Test]
        public void WhenDivisibleBy3_ReturnsFizz()
        {
            const int divBy3 = 12;
            var fizz = _fizzBuzzes.ElementAt(divBy3 - 1);

            Assert.AreEqual(fizz, "Fizz");
        }

        [Test]
        public void WhenDivisibleBy5_ReturnsBuzz()
        {
            const int divBy5 = 50;
            var buzz = _fizzBuzzes.ElementAt(divBy5 - 1);

            Assert.AreEqual(buzz, "Buzz");
        }

        [Test]
        public void WhenDivisibleBy3And5_ReturnsFizzBuzz()
        {
            const int divBy15 = 15;
            var fizzBuzz = _fizzBuzzes.ElementAt(divBy15 - 1);

            Assert.AreEqual(fizzBuzz, "FizzBuzz");
        }


        [Test]
        public void WhenNotDivisibleBy3Or5_ReturnsOriginalNumber()
        {
            const int coPrime15 = 77;
            var seventySeven = _fizzBuzzes.ElementAt(coPrime15 - 1);

            Assert.AreEqual(seventySeven, "77");
        }

        [Test]
        public void WhenUsingFooBarAndNumberIsDivisibleBy7_ReturnsFoo()
        {
            const int divBy7 = 14;
            var foo = _fooBars.ElementAt(divBy7 - 1);
            if (foo == null) throw new ArgumentNullException(nameof(foo));

            Assert.AreEqual(foo, "Foo");
        }

        [Test]
        public void WhenUsingFooBarAndNumberIsDivisibleBy11_ReturnsBar()
        {
            const int divBy11 = 22;
            var bar = _fooBars.ElementAt(divBy11 - 1);

            Assert.AreEqual(bar, "Bar");
        }

        [Test]
        public void WhenUsingFooBarAndNumberIsDivisibleBy7And11_ReturnsFooBar()
        {
            const int divBy77 = 77;
            var foobar = _fooBars.ElementAt(divBy77 - 1);

            Assert.AreEqual(foobar, "FooBar");
        }

        [Test]
        public void WhenUsingFooBarAndNumberIsNotDivisibleBy7And11_ReturnsNumber()
        {
            const int coPrime77 = 50;
            var fifty = _fooBars.ElementAt(coPrime77 - 1);

            Assert.AreEqual(fifty, "50");
        }

        [Test]
        public void WhenUsingBazAndNumberIsDivisibleBy97_ReturnsBaz()
        {
            const int divBy97 = 97 * 2;
            var baz = _bazes.ElementAt(divBy97 - 1);

            Assert.AreEqual(baz, "Baz");
        }

        [Test]
        public void WhenPassingNonPositiveToFizzBuzzConstructor_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new FizzBuzz(0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new FizzBuzz(-1));

            // second argument is ignored if first argument is OutOfRange
            Assert.Throws<ArgumentOutOfRangeException>(() => new FizzBuzz(0, null));
            Assert.Throws<ArgumentOutOfRangeException>(() => new FizzBuzz(-1, null));
        }

        [Test]
        public void WhenPassingNullToFizzBuzzConstructor_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => new FizzBuzz(1234, null));
        }

        [Test]
        public void WhenPassingEmptyListToFizzBuzzConstructor_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new FizzBuzz(1234, new List<NumberKeywordPair>()));
        }
    }
}