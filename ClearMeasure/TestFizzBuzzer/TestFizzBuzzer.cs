using System;

using NUnit.Framework;
using System.Linq;
using ClearMeasure;
using System.Collections.Generic;

namespace TestFizzBuzzProject
{
    [TestFixture]
    public class TestFizzBuzzer
    {
        private FizzBuzz _myFizzerBuzzer;
        private IEnumerable<string> _fizzBuzzes;

        private FizzBuzz _myFooBarrer;
        private IEnumerable<string> _fooBarrer;

        [OneTimeSetUp]
        public void Setup()
        {
            _myFizzerBuzzer = new FizzBuzz(int.MaxValue);
            _fizzBuzzes = _myFizzerBuzzer.GetFizzBuzzNums();

            _myFooBarrer = new FizzBuzz(int.MaxValue,
                new List<Tuple<int, string>> {new Tuple<int, string>(7, "Foo"), new Tuple<int, string>(11, "Bar")});
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
    }
}