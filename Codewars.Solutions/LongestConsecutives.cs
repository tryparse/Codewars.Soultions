using System;
using System.Linq;

namespace Codewars.Solutions
{
    /// <summary>
    /// You are given an array strarr of strings and an integer k. 
    /// Your task is to return the first longest string consisting of k consecutive strings taken in the array.
    /// </summary>
    public class LongestConsecutives
    {
        public string LongestConsec(string[] strarr, int k)
        {
            if (strarr.Length == 0
                || k > strarr.Length
                || k <= 0)
            {
                return string.Empty;
            }

            var sum = new int[strarr.Length];

            for (int i = 0; i < strarr.Length; i++)
            {
                sum[i] = strarr
                    .Skip(i)
                    .Take(k)
                    .Sum(x => x.Length);
            }

            var index = Array.IndexOf(sum, sum.Max());

            var result = string.Join(string.Empty, strarr
                .Skip(index)
                .Take(k));

            return result;
        }
    }
}
