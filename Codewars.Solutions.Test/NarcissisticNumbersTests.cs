using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars.Solutions.Test
{
    [TestClass]
    public class NarcissisticNumbersTests
    {
        [DataTestMethod()]
        [DataRow(1)]
        [DataRow(371)]
        [DataRow(153)]
        [DataRow(1634)]
        public void NarcissisticTest(int value)
        {
            var solver = new NarcissisticNumbers();
            var result = solver.Narcissistic(value);
            Assert.IsTrue(result);
        }
    }
}
