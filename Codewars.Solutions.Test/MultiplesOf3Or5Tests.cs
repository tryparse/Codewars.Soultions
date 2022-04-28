using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codewars.Solutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.Solutions.Tests
{
    [TestClass()]
    public class MultiplesOf3Or5Tests
    {
        [DataTestMethod]
        [DataRow(23,10)]
        public void SolutionTest(int expected, int n)
        {
            Assert.AreEqual(expected, MultiplesOf3Or5.Solution(n));
        }
    }
}