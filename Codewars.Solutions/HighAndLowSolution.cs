using System;
using System.Linq;

namespace Codewars.Solutions
{
    public static class HighAndLowSolution
    {
        public static string HighAndLow(string numbers)
        {
            var nums = numbers
                .Split(" ", System.StringSplitOptions.RemoveEmptyEntries)
                .Select(x => Convert.ToInt32(x));

            return $"{nums.Max()} {nums.Min()}";
        }
    }
}
