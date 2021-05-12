using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Sum(x => x * (int)Math.Pow(-1, x % 2));
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return new string[] { str1, str2, str3, str4 }.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return new int[] { number1, number2, number3, number4 }.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return new int[] { sideLength1, sideLength2, sideLength3 }.OrderByDescending(x => x).Aggregate((agg, num) => agg - num) < 0;
        }

        public bool IsStringANumber(string input)
        {
            return Double.TryParse(input, out double result);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Count(x => x == null) > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            return (numbers ?? Array.Empty<int>()).Where(x => x % 2 == 0).DefaultIfEmpty().Average();
        }

        public int Factorial(int number)
        {
            return Enumerable.Range(1, number).DefaultIfEmpty(1).Aggregate((fac, num) => fac * num);
        }
    }
}
