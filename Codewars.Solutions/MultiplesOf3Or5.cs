namespace Codewars.Solutions
{
    /// <summary>
    /// https://www.codewars.com/kata/514b92a657cdc65150000006/train/csharp
    /// </summary>
    public static class MultiplesOf3Or5
    {
        public static int Solution(int value)
        {
            var sum = 0;

            for (int i = 1; i < value; i++)
            {
                if (i % 3 == 0
                    || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
