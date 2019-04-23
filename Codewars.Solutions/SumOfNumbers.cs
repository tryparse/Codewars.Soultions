using System;

namespace Codewars.Solutions
{
    public class SumOfNumbers
    {
        public int GetSum(int a, int b)
        {
            //Good Luck!
            if (a == b)
            {
                return a;
            }

            var min = Math.Min(a, b);
            var max = Math.Max(a, b);

            var sum = 0;

            for (int i=min; i<=max; i++)
            {
                sum += i;
            }

            return sum;
        }

        public int GetSumAlternative(int a, int b)
        {
            return 0;
        }
    }
}
