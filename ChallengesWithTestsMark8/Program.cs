using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Enumerable.Range(1, 100).Average(x => x * x));
            var strings = new string[] { "abc", "def1" };
            var chal3 = new ChallengesSet03();
            chal3.ChangeAllElementsToUppercase(strings);
            Console.WriteLine(strings[1]);
        }
    }
}
