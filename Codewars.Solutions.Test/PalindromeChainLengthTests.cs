using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codewars.Solutions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Codewars.Solutions.Tests
{
    [TestClass()]
    public class PalindromeChainLengthTests
    {
        [DataTestMethod]
        [DataRow(1, true)]
        [DataRow(12, false)]
        [DataRow(121, true)]
        [DataRow(1221, true)]
        [DataRow(1231, false)]
        public void IsPalindromeTest(int n, bool expected)
        {
            var result = PalindromeChainLength.IsPalindrome(n);

            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(1, 0)]
        [DataRow(87, 4)]
        [DataRow(89, 24)]
        public void palindromeChainLengthTest(int n, int expected)
        {
            var result = PalindromeChainLength.palindromeChainLength(n);

            Assert.AreEqual(expected, result);
        }
    }
}