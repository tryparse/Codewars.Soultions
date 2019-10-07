using System.Collections.Generic;
using System.Linq;

namespace Codewars.Solutions
{
    public class HighestRankNumberInAnArray
    {
        public static int HighestRank(int[] arr)
        {
            var result = new Dictionary<int, int>();

            foreach (var i in arr)
            {
                if (result.ContainsKey(i))
                {
                    result[i]++;
                }
                else
                {
                    result.Add(i, 1);
                }
            }

            return result
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x => x.Key)
                .FirstOrDefault()
                .Key;
        }
    }
}
