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
    public class ASumTests
    {
        [DataTestMethod]
        [DataRow(2022, 4183059834009)]
        [DataRow(-1, 24723578342962)]
        [DataRow(4824, 135440716410000)]
        public void FindNbTest(long expected, long m)
        {
            Assert.AreEqual(expected, ASum.FindNb(m));
        }
    }
}