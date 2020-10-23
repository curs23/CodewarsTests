using CodewarsTests;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Linq;
using System.Numerics;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Введите значение:");
                string val = Console.ReadLine();
                if (val == string.Empty) return;
                long dig = long.Parse(val);



                Console.WriteLine(DigitalRoot(dig));
                Console.WriteLine(dig%9);



            } while (true);

            //Console.ReadKey();
        }

        public static int DigitalRoot(long n)
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

        public static int Dr(long n)
        {
            return (int)(1 + (n - 1) % 9);
        }
    }
}
