using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars.Solutions.Test
{
    [TestClass]
    public class SumOfNumbersTests
    {
        SumOfNumbers sum;

        [TestInitialize]
        public void Initialize()
        {
            sum = new SumOfNumbers();
        }

        [TestMethod]
        public void Test1()
        {
            Assert.AreEqual(1, sum.GetSum(1, 0));
            Assert.AreEqual(3, sum.GetSum(1, 2));
            Assert.AreEqual(1, sum.GetSum(0, 1));
            Assert.AreEqual(1, sum.GetSum(1, 1));
            Assert.AreEqual(-1, sum.GetSum(-1, 0));
            Assert.AreEqual(2, sum.GetSum(-1, 2));
        }
    }
}
