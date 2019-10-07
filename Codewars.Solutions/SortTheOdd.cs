using System.Collections.Generic;
using System.Linq;

namespace Codewars.Solutions
{
    /// <summary>
    /// <remarks>https://www.codewars.com/kata/578aa45ee9fd15ff4600090d</remarks>
    /// </summary>
    public class SortTheOdd
    {
        public static int[] SortArray(int[] array)
        {
            var even = new Dictionary<int, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    even.Add(i, array[i]);
                }
            }
            var list = array.Where(x => x % 2 != 0)
                .OrderBy(x => x)
                .ToList();
            
            foreach (var e in even)
            {
                list.Insert(e.Key, e.Value);
            }

            return list.ToArray();
        }
    }
}
