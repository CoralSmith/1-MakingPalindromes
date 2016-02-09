using System;
using System.Linq;
using System.Numerics;

namespace Palindromes
{
    public static class PalindromeMaker
    {
        const int maxSteps = 100;
        public static BigInteger From(int value, out int steps)
        {
            steps = 0;
            BigInteger result = value;
            if (value.ToString().Length > 1)
            {
                while (!IsPalindrome(result) && steps < maxSteps)
                {
                    steps++;
                    BigInteger swap = BigInteger.Parse(string.Concat(result.ToString().Reverse()));
                    result += swap;
                }
                if (!IsPalindrome(result) && steps == maxSteps) throw new ApplicationException("Possible Lychrel number");
            }
            return result;
        }

        private static bool IsPalindrome(BigInteger value)
        {
            return value == BigInteger.Parse(string.Concat(value.ToString().Reverse()));
        }
    }
}
