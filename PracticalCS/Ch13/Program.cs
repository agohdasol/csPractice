using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ch13.Models;

namespace Ch13
{
    class Program
    {
        static void InsertBooks()
        {
            using (var db = new BooksDbContext())
            {
                var book1 = new Book
                {
                    Title = "별의 계승자",
                    PublishedYear = 1977,
                    Author = new Author
                    {
                        Birthday = new DateTime(1941, 6, 27),
                        Gender = "M",
                        Name = "제임스 P. 호건",
                    }
                };
                db.Books.Add(book1);
                var book2 = new Book
                {
                    Title = "타임머신",
                    PublishedYear = 1895,
                    Author = new Author
                    {
                        Birthday = new DateTime(1866, 9, 21),
                        Gender = "M",
                        Name = "허버트 조지 웰즈",
                    }
                };
                db.Books.Add(book2);
                db.SaveChanges();
            }
        }
        static void Main()
        {
            InsertBooks();
            Console.WriteLine("qwe");
        }
    }
}
