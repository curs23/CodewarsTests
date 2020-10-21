using NUnit.Framework;
using System;
using System.Linq;

namespace CodewarsTests
{
    public class Kata
    {

        public static int DescendingOrder(int num)
        {
            char[] charArr = num.ToString().ToCharArray();
            Array.Sort(charArr);
            Array.Reverse(charArr);
            return int.Parse(new string(charArr));
        }

        public static string CreatePhoneNumber(int[] numbers)
        {
            return $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
        }
    }

    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test0()
        {
            Assert.AreEqual(98521, Kata.DescendingOrder(21589));
        }

        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, ExpectedResult = "(123) 456-7890")]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, ExpectedResult = "(111) 111-1111")]
        public static string FixedTest(int[] numbers)
        {
            return Kata.CreatePhoneNumber(numbers);
        }
    }
}