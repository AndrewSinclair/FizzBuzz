using System;

using NUnit.Framework;

namespace NUnitTestProject1
{
    [TestFixture]
    public class NUnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            //Unit test 15 case
            Assert.AreEqual(ClearMeasure.FizzBuzz.FizzBuzzNum(15), "FizzBuzz\n");
        }

        // Additional Unit Tests
    }
}