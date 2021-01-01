using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex6
{
    class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }
    class Program
    {
        static void Main()
        {
            //6.1
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };
            //6.1 - 1
            Console.WriteLine(numbers.Max());
            Console.WriteLine("------");
            //6.1 - 2
            var last2numbers = numbers.Skip(numbers.Length - 2).ToList();
            last2numbers.ForEach(Console.WriteLine);
            Console.WriteLine("------");
            //6.1 - 3
            var stringNumbers = numbers.Select(x => x.ToString()).ToList();
            stringNumbers.ForEach(Console.WriteLine);
            Console.WriteLine("------");
            //6.1 - 4
            var small3=numbers.OrderBy(x => x).Take(3).ToList();
            small3.ForEach(Console.WriteLine);
            Console.WriteLine("------");
            //6.1 - 5
            Console.WriteLine(numbers.Distinct().Count(x => x > 10));
            Console.WriteLine("------");

            //6.2
            Console.WriteLine("6.2----");
            var books = new List<Book>
            {
                new Book{Title="태평천하 C#", Price=400, Pages=378},
                new Book{Title="운수 좋은 날", Price=281, Pages=212},
                new Book{Title="만세전", Price=389, Pages=201},
                new Book{Title="삼대", Price=637, Pages=464},
                new Book{Title="상록수 C#", Price=411, Pages=276},
                new Book{Title="혈의 누", Price=961, Pages=666},
                new Book{Title="금수회의록 C#", Price=514, Pages=268},
            };
            //6.2 - 1
            var ex621 = books.FirstOrDefault(x => x.Title == "만세전");
            Console.WriteLine($"{ex621.Price}, {ex621.Pages}");
            Console.WriteLine("------");
            //6.2 - 2
            var ex622 = books.Count(x => x.Title.Contains("C#"));
            Console.WriteLine(ex622);
            Console.WriteLine("------");
            //6.2 - 3
            var ex623 = books.Where(x => x.Title.Contains("C#")).ToList().Average(x=>x.Pages);
            Console.WriteLine(ex623);
            Console.WriteLine("------");
            //6.2 - 4
            var ex624 = books.FirstOrDefault(x => x.Price >= 400);
            Console.WriteLine(ex624.Title);
            Console.WriteLine("------");
            //6.2 - 5
            var ex625 = books.Where(x => x.Price <= 400);
            var ex625max = ex625.Max(x => x.Pages);
            var ex625page = ex625.FirstOrDefault(x => x.Pages == ex625max);
            Console.WriteLine(ex625page.Pages);
            Console.WriteLine("------");
            //6.2 - 6
            var ex626 = books.Where(x => x.Pages >= 400).OrderBy(x => x.Price);
            foreach (var item in ex626)
            {
                Console.WriteLine($"{item.Title} {item.Price}");
            }
            Console.WriteLine("------");
            //6.2 - 7
            var ex627 = books.Where(x => x.Title.Contains("C#"))
                            .Where(x => x.Price <= 500);
            foreach (var item in ex627)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
