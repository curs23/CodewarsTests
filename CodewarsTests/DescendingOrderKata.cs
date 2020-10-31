using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodewarsTests
{
    class DescendingOrderKata
    {
        public static int DescendingOrder(int num)
        {
            char[] charArr = num.ToString().ToCharArray();
            Array.Sort(charArr);
            Array.Reverse(charArr);
            return int.Parse(new string(charArr));
        }
    }

    class DescendingOrderTest
    {
        [Test]
        public void Test0()
        {
            Assert.AreEqual(98521, DescendingOrderKata.DescendingOrder(21589));
        }
    }

}
