using System;
using System.Linq;
using System.Text;

namespace Codewars.Solutions
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>https://www.codewars.com/kata/525f039017c7cd0e1a000a26</remarks>
    public static class PalindromeChainLength
    {
        public static int palindromeChainLength(int n)
        {
            var iteration = 0;
            var l = (long)n;

            while (!IsPalindrome(l))
            {
                var reverse = Convert.ToInt64(ReverseString(l.ToString()));

                l += reverse;

                iteration++;
            }

            return iteration;
        }

        public static bool IsPalindrome(long l)
        {
            if (l < 10)
            {
                return true;
            }

            var s = l.ToString();

            return s == ReverseString(s);
        }

        private static string ReverseString(string s)
        {
            return new string(s.ToCharArray().Reverse().ToArray());
        }
    }
}
