using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Ex3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            // 1
            bool test1 = numbers.Exists(s => s % 8 == 0 || s % 9 == 0);
            Console.WriteLine(test1);
            Console.WriteLine("------");

            //2
            numbers.ForEach(s => Console.WriteLine(s / 2.0));
            Console.WriteLine("------");

            //3
            IEnumerable test3 = numbers.Where<int>(s => s >= 50);
            foreach (var item in test3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");

            //4
            List<int> test4 = numbers.Select(n => n * 2).ToList();
            foreach (var item in test4)
            {
                Console.WriteLine(item);
            }
        }
    }
}
