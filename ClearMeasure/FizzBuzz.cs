using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearMeasure
{
    public class FizzBuzz
    {
        // TODO : Max Value no Memory Overflow
        // Features: Pass in arbitrary numbers, words combos (as many as they want).
        // Extra Credit: Build script, Git + CI

        // Put it all on Github
        public static string FizzBuzzNum(int num)
        {
            StringBuilder builder = new StringBuilder();

            if (num % 3 == 0)
            {
                builder.Append("Fizz");
            }
            if (num % 5 == 0)
            {
                builder.Append("Buzz");
            }
            if (num % 3 != 0 && num % 5 != 0)
            {
                builder.Append(num);
            }
            builder.Append("\n");

            return builder.ToString();
        }

        public static string GetFizzBuzz(int upperBound)
        {

            StringBuilder builder = new StringBuilder();

            for (int i = 1; i <= upperBound; i++)
            {
                string fizzOrBuzzOrNum = FizzBuzzNum(i);
                builder.Append(fizzOrBuzzOrNum);
            }
            return builder.ToString();
        }
    }
}
