using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>
            {
                "Seoul", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            //1
            Console.Write("도시명을 입력하세요 : ");
            var line = Console.ReadLine();
            int nameIndex = names.FindIndex(n => n == line);
            Console.WriteLine(nameIndex);
            Console.WriteLine("------");

            //2
            var count = names.Count(n => n.Contains('o'));
            Console.WriteLine(count);
            Console.WriteLine("------");

            //3
            var test3 = names.Where<string>(s => s.Contains('o')).ToList();
            foreach (var item in test3)
            {
                Console.WriteLine(item);
            }

            //4
            var test4 = names.Where<string>(s => s.StartsWith('B'))
                .Select(s => s.Length);
            foreach (var item in test4)
            {
                Console.WriteLine(item);
            }
        }
    }
}
