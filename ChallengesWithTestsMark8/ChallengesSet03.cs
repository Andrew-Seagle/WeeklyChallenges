using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return !Array.TrueForAll(vals, x => x);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            return numbers != null && (numbers.Where(x => x % 2 != 0).Sum()) % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return (password.Where(x => Char.IsLetterOrDigit(x)).Select(x => Char.IsDigit(x) ? 1 : Char.IsUpper(x) ? 2 : 3).Distinct().Count()) == 3;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            return Enumerable.Range(1, 99).Where(x => x % 2 != 0).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            words.Select(x => x.ToUpper()).ToArray().CopyTo(words, 0);
        }
    }
}
