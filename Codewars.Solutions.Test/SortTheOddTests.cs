using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars.Solutions.Test
{
    [TestClass]
    public class SortTheOddTests
    {
        [DataTestMethod]
        [DataRow(new [] {5, 3, 2, 8, 1, 4}, new []{ 1, 3, 2, 8, 5, 4 })]
        public void SolutionTest(int[] input, int[] expected)
        {
            var actual = SortTheOdd.SortArray(input);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
