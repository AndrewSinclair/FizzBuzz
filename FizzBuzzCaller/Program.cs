using System;
using System.Collections.Generic;
using ClearMeasure;


namespace FizzBuzzCaller
{
    public class Program
    {
        public static void Main()
        {
            var myFizzBuzz = new FizzBuzz(100, new List<NumberKeywordPair>() { new NumberKeywordPair { Number = 10, Keyword = "Foo"} });
            var fizzBuzzes = myFizzBuzz.GetFizzBuzzNums();

            foreach (var fizzBuzzOrNum in fizzBuzzes)
            {
                Console.WriteLine(fizzBuzzOrNum);
            }

            Console.WriteLine("End of Program");
        }
    }
}
