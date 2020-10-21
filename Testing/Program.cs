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


            } while (true);

            //Console.ReadKey();
        }

        /// <summary>
        /// новые знания
        /// </summary>
        void NewKnowledge()
        {
            char[] byteArray = new char[] { 'a', 'b', 'c' };
            
            // сортировка массива
            Array.Sort(byteArray);
            
            // развернуть порядок значений в массиве
            Array.Reverse(byteArray);
            
            // массива чаров склеивает в строку
            string str = new string(byteArray);
            
            // сортировка символов в строке LINQ
            IOrderedEnumerable<char> oe = str.OrderByDescending(x => x);
            
            // склеивание значний массива в строку
            str.Concat(oe);
            str.Concat(byteArray);

        }
    }
}
