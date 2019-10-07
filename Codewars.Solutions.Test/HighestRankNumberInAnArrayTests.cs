using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars.Solutions.Test
{
    [TestClass]
    public class HighestRankNumberInAnArrayTests
    {
        [DataTestMethod]
        [DataRow(new[] {12, 10, 8, 12, 7, 6, 4, 10, 12}, 12)]
        [DataRow(new[] {12, 10, 8, 12, 7, 6, 4, 10, 12, 10}, 12)]
        [DataRow(new[] {12, 10, 8, 8, 3, 3, 3, 3, 2, 4, 10, 12, 10}, 3)]
        public void HighestRankTest(int[] input, int expected)
        {
            var actual = HighestRankNumberInAnArray.HighestRank(input);

            Assert.AreEqual(expected, actual);
        }
    }
}
