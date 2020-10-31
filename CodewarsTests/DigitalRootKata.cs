using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CodewarsTests
{
    class DigitalRootKata
    {
        public int DigitalRoot(long n)
        {
            if (n < 10) return (int)n;
            var charArr = n.ToString().ToCharArray();
            int sum = 0;
            foreach (var dig in charArr)
            {
                sum += int.Parse(dig.ToString());
            }
            if (sum > 9) { return DigitalRoot(sum); }
            return sum;
        }
    }

    [TestFixture]
    class NumberTest
    {
        private DigitalRootKata num;

        [SetUp]
        public void SetUp()
        {
            num = new DigitalRootKata();
        }

        [TearDown]
        public void TearDown()
        {
            num = null;
        }

        [Test]
        public void Tests()
        {
            Assert.AreEqual(7, num.DigitalRoot(16));
            Assert.AreEqual(6, num.DigitalRoot(456));
        }
    }
}
