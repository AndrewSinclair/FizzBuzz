using System;

using NUnit.Framework;
using System.Linq;
using ClearMeasure;
using System.Collections.Generic;

namespace NUnitTestProject1
{
    [TestFixture]
    public class NUnitTest1
    {
        private FizzBuzz _myFizzerBuzzer;
        private IEnumerable<string> _fizzBuzzes;

        [OneTimeSetUp]
        public void Setup()
        {
            _myFizzerBuzzer = new FizzBuzz(Int32.MaxValue);
            _fizzBuzzes = _myFizzerBuzzer.GetFizzBuzz();
        }

        [Test]
        public void WhenDivisibleBy3_ReturnsFizz()
        {
            int divBy3 = 12;
            string fizz = _fizzBuzzes.ElementAt(divBy3 - 1);

            Assert.AreEqual(fizz, "Fizz");
        }

        [Test]
        public void WhenDivisibleBy5_ReturnsBuzz()
        {
            int divBy5 = 50;
            string buzz = _fizzBuzzes.ElementAt(divBy5 - 1);

            Assert.AreEqual(buzz, "Buzz");
        }

        [Test]
        public void WhenDivisibleBy3And5_ReturnsFizzBuzz()
        {
            int divBy15 = 15;
            string fizzBuzz = _fizzBuzzes.ElementAt(divBy15 - 1);

            Assert.AreEqual(fizzBuzz, "FizzBuzz");
        }

    }
}