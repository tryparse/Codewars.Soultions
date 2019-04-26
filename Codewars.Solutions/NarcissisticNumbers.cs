using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars.Solutions
{
    public class NarcissisticNumbers
    {
        public bool Narcissistic(int value)
        {
            var str = value.ToString();
            var n = str.Length;
            int sum = 0;

            foreach (var c in str)
            {
                sum += (int)Math.Pow(int.Parse(c.ToString()), n);
            }

            return value == sum;
        }
    }
}
