using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            return numbers != null ? numbers.DefaultIfEmpty().Max() + numbers.DefaultIfEmpty().Min() : 0;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            return numbers != null ? numbers.Sum() : 0;
        }

        public int SumEvens(int[] numbers)
        {
            return numbers != null ? numbers.Where(num => num % 2 == 0).Sum() : 0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return numbers != null && numbers.Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            return number > 0 ? number / 2 : 0;
        }
    }
}
