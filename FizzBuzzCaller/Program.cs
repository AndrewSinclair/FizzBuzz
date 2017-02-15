using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClearMeasure;


namespace FizzBuzzCaller
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz myFizzBuzz = new FizzBuzz(Int32.MaxValue);
            IEnumerable<string> fizzBuzzes = myFizzBuzz.GetFizzBuzz();

            foreach (var fizzBuzzOrNum in fizzBuzzes)
            {
                Console.WriteLine(fizzBuzzOrNum);
            }

            Console.WriteLine("End of Program");
        }
    }
}
