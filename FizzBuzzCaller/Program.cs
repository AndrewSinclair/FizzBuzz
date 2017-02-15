using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FizzBuzzCaller
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = ClearMeasure.FizzBuzz.GetFizzBuzz(Int32.MaxValue);
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
