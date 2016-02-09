using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes;
using System;
using System.Numerics;

namespace PalidromesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given5Returns5WithSteps()
        {
            int step;
            Assert.AreEqual(5, PalindromeMaker.From(5, out step));            
        }

        [TestMethod]
        public void Given5WithStepsReturns0Steps()
        {
            int step;
            PalindromeMaker.From(5, out step);
            Assert.AreEqual(0, step);
        }

        [TestMethod]
        public void Given10Return11WithSteps()
        {
            int step;
            Assert.AreEqual(11, PalindromeMaker.From(10, out step));
            Assert.AreEqual(1, step);
        }

        [TestMethod]
        public void Given24Return66()
        {
            int step;
            Assert.AreEqual(66, PalindromeMaker.From(24, out step));
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void Given196ThrowsException()
        {
            int step;
            PalindromeMaker.From(196, out step);
        }

        [TestMethod]
        public void GivenValReturnsPalindromeInSteps()
        {
            int step;
            Assert.AreEqual(444, PalindromeMaker.From(123, out step));
            Assert.AreEqual(1, step);
            Assert.AreEqual(8813200023188, PalindromeMaker.From(286, out step));
            Assert.AreEqual(23, step);
            Assert.AreEqual(BigInteger.Parse("4478555400006996000045558744"), PalindromeMaker.From(196196871, out step));
            Assert.AreEqual(45, step);
        }
    }
}
