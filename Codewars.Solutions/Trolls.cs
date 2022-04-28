using System.Collections.Generic;

namespace Codewars.Solutions
{
    public class Trolls
    {
        public static string Disemvowel(string str)
        {
            var toRemove = new List<string>
        {
          "A","a",
          "E", "e",
          "I", "i",
          "O", "o",
          "U", "u"
        };

            foreach (var remove in toRemove)
            {
                str = str.Replace(remove, string.Empty);
            }

            return str;
        }
    }
}
