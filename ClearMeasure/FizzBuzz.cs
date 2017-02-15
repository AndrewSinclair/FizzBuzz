using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearMeasure
{
    public class FizzBuzz
    {
        private int _num;

        public FizzBuzz(int num)
        {
            _num = num;
        }

        private string FizzBuzzNum(int num)
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

            return builder.ToString();
        }

        public IEnumerable<string> GetFizzBuzz()
        {
            for(int i = 1; i <= _num; i++)
            {
                yield return FizzBuzzNum(i);
            }
        }
    }
}
