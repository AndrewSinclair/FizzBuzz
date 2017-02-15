using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearMeasure
{
    public class FizzBuzz
    {
        private readonly int _num;
        public List<Tuple<int, string>> NumNamePairs { get; }

        public FizzBuzz(int num)
        {
            _num = num;
            NumNamePairs = new List<Tuple<int, string>>()
            {
                new Tuple<int, string>(3, "Fizz"),
                new Tuple<int, string>(5, "Buzz")
            };
        }

        public FizzBuzz(int num, List<Tuple<int, string>> numNamePairs)
        {
            _num = num;
            NumNamePairs = numNamePairs;
        }

        private string GetFizzBuzzNum(int num)
        {
            var divisors = NumNamePairs.FindAll(nnp => num % nnp.Item1 == 0);

            return
                divisors.Count > 0 ?
                string.Join(string.Empty, divisors.Select(nnp => nnp.Item2)) :
                num.ToString();
        }

        public IEnumerable<string> GetFizzBuzzNums()
        {
            for(var i = 1; i <= _num; i++)
            {
                yield return GetFizzBuzzNum(i);
            }
        }
    }
}
