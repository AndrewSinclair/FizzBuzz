using System;
using System.Collections.Generic;
using System.Linq;

namespace ClearMeasure
{
    public class FizzBuzz
    {
        private readonly int _num;

        public List<NumberKeywordPair> NumNamePairs { get; }

        public FizzBuzz(int num)
        {
            if (num <= 0) throw new ArgumentOutOfRangeException(nameof(num));
            _num = num;
            NumNamePairs = new List<NumberKeywordPair>()
            {
                new NumberKeywordPair {Number = 3, Keyword = "Fizz"},
                new NumberKeywordPair {Number = 5, Keyword = "Buzz"}
            };
        }

        public FizzBuzz(int num, List<NumberKeywordPair> numNamePairs)
        {
            if (num <= 0) throw new ArgumentOutOfRangeException(nameof(numNamePairs));
            if (numNamePairs == null) throw new ArgumentNullException(nameof(numNamePairs));
            if (numNamePairs.Count == 0) throw new ArgumentException("List of Num-Name-Pairs cannot be empty.");

            _num = num;
            NumNamePairs = numNamePairs;
        }

        private string GetFizzBuzzNum(int num)
        {
            var divisors = NumNamePairs.FindAll(pair => num % pair.Number == 0);

            return
                divisors.Count > 0 ?
                string.Join(string.Empty, divisors.Select(pair => pair.Keyword)) :
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
