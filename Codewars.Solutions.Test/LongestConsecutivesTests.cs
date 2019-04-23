using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars.Solutions.Test
{
    [TestClass]
    public class LongestConsecutivesTests
    {
        LongestConsecutives longest;

        [TestInitialize]
        public void Initialize()
        {
            longest = new LongestConsecutives();
        }

        [DataTestMethod()]
        [DataRow(new String[] { "zone", "abigail", "theta", "form", "libe", "zas", "theta", "abigail" }, 2, "abigailtheta")]
        [DataRow(new String[] {"ejjjjmmtthh", "zxxuueeg", "aanlljrrrxx", "dqqqaaabbb", "oocccffuucccjjjkkkjyyyeehh"}, 1, "oocccffuucccjjjkkkjyyyeehh")]
        [DataRow(new String[] {}, 3, "")]
        [DataRow(new String[] {"itvayloxrp","wkppqsztdkmvcuwvereiupccauycnjutlv","vweqilsfytihvrzlaodfixoyxvyuyvgpck"}, 2, "wkppqsztdkmvcuwvereiupccauycnjutlvvweqilsfytihvrzlaodfixoyxvyuyvgpck")]
        [DataRow(new String[] {"wlwsasphmxx","owiaxujylentrklctozmymu","wpgozvxxiu"}, 2, "wlwsasphmxxowiaxujylentrklctozmymu")]
        [DataRow(new String[] {"zone", "abigail", "theta", "form", "libe", "zas"}, -2, "")]
        [DataRow(new String[] {"it","wkppv","ixoyx", "3452", "zzzzzzzzzzzz"}, 3, "ixoyx3452zzzzzzzzzzzz")]
        [DataRow(new String[] {"it","wkppv","ixoyx", "3452", "zzzzzzzzzzzz"}, 15, "")]
        [DataRow(new String[] {"it","wkppv","ixoyx", "3452", "zzzzzzzzzzzz"}, 0, "")]
        public void Test1(string[] strarr, int k, string expected)
        {
            var actual = longest.LongestConsec(strarr, k);

            Assert.AreEqual(expected, actual);
        }
    }
}
