namespace Codewars.Solutions
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>https://www.codewars.com/kata/5592e3bd57b64d00f3000047/train/csharp</remarks>
    public static class ASum
    {
        public static long FindNb(long m)
        {
            long n = 0;
            long i = 0;

            while (n < m)
            {
                n += ++i * i * i;
            }

            if (n == m) return i;
            return -1;
        }
    }
}
