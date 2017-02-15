using System;
using ClearMeasure;


namespace FizzBuzzCaller
{
    internal class Program
    {
        private static void Main()
        {
            var myFizzBuzz = new FizzBuzz(int.MaxValue);
            var fizzBuzzes = myFizzBuzz.GetFizzBuzzNums();

            foreach (var fizzBuzzOrNum in fizzBuzzes)
            {
                Console.WriteLine(fizzBuzzOrNum);
            }

            Console.WriteLine("End of Program");
        }
    }
}
