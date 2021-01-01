using System;
using System.Collections.Generic;
using System.Linq;

namespace Ch6
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
            var books = new List<Book>
            {
                new Book{Title="태평천하", Price=400, Pages=378},
                new Book{Title="운수 좋은 날", Price=281, Pages=212},
                new Book{Title="만세전", Price=389, Pages=201},
                new Book{Title="삼대", Price=637, Pages=464},
                new Book{Title="상록수", Price=411, Pages=276},
                new Book{Title="혈의 누", Price=961, Pages=666},
                new Book{Title="금수회의록", Price=514, Pages=268},
            };
            var numbers = Enumerable.Repeat(-1, 20).ToList();
        }
    }
}
