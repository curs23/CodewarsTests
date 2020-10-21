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
            string str = "759";
            Console.WriteLine(str);
            IOrderedEnumerable<char> s = str.OrderByDescending(x => x);
            
            //string.Concat()
            
            
            Console.WriteLine(str);
            Console.ReadKey();





            return;
            do
            {
                Console.WriteLine("Введите число (q - выход):");
                string numStr = Console.ReadLine();
                if (numStr == "q") { break; }
                else
                {
                    Console.WriteLine(Kata.DescendingOrder(int.Parse(numStr)));
                    Console.WriteLine("----------");
                }
            } while (true);

            //Console.ReadKey();
        }
    }
}
