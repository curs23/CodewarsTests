using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CodewarsTests
{
    class CountBitsKata
    {
        public static int CountBits(int n)
        {
            return (from ch in Convert.ToString(n, 2) where ch == '1' select ch).Count();
        }
    }

    [TestFixture]
    public class BitCounting
    {
        [Test]
        public void CountBits()
        {
            Assert.AreEqual(0, CountBitsKata.CountBits(0));
            Assert.AreEqual(1, CountBitsKata.CountBits(4));
            Assert.AreEqual(3, CountBitsKata.CountBits(7));
            Assert.AreEqual(2, CountBitsKata.CountBits(9));
            Assert.AreEqual(2, CountBitsKata.CountBits(10));
        }
    }
}
