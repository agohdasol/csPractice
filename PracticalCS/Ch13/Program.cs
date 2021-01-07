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
        static IEnumerable<Book> GetBooks()
        {
            using(var db=new BooksDbContext())
            {
                return db.Books
                    .Include(nameof(Author))
                    .ToList();
            }
        }
        static void DisplayAllBooks()
        {
            var books = GetBooks();
            foreach (var book in books)
                Console.WriteLine($"{book.Title} {book.PublishedYear} {book.Author.Name}");
            Console.ReadLine();
        }
        static void AddAuthors()
        {
            using(var db=new BooksDbContext())
            {
                var author1 = new Author
                {
                    Birthday = new DateTime(1947, 09, 21),
                    Gender = "M",
                    Name = "스티븐 킹"
                };
                db.Authors.Add(author1);
                var author2 = new Author
                {
                    Birthday = new DateTime(1911, 09, 19),
                    Gender = "F",
                    Name = "윌리엄 골딩"
                };
                db.Authors.Add(author2);
                db.SaveChanges();
            }
        }
        static void AddBooks()
        {
            using(var db=new BooksDbContext())
            {
                var author1 = db.Authors.Single(a => a.Name == "스티븐 킹");
                var book1 = new Book
                {
                    Title = "샤이닝",
                    PublishedYear = 1977,
                    Author = author1
                };
                db.Books.Add(book1);
                var author2 = db.Authors.Single(a => a.Name == "애거사 크리스티");
                var book2 = new Book
                {
                    Title = "밀물을 타고",
                    PublishedYear = 1843,
                    Author = author2
                };
                db.Books.Add(book2);
                var author3 = db.Authors.Single(a => a.Name == "찰스 디킨스");
                var book3 = new Book
                {
                    Title = "크리스마스 캐럴",
                    PublishedYear = 1843,
                    Author = author3
                };
                db.Books.Add(book3);
                var author4 = db.Authors.Single(a => a.Name == "윌리엄 골딩");
                var book4 = new Book
                {
                    Title = "파리대왕",
                    PublishedYear = 1954,
                    Author = author4
                };
                db.Books.Add(book4);
                db.SaveChanges();
            }
        }
        //13.11
        static void UpdateBook()
        {
            using(var db=new BooksDbContext())
            {
                var book = db.Books.Single(x => x.Title == "별의 계승자");
                book.PublishedYear = 2016;
                db.SaveChanges();
            }
        }
        //13.12
        static void DeleteBook()
        {
            using(var db=new BooksDbContext())
            {
                var book = db.Books.SingleOrDefault(x => x.Id == 10);
                if (book != null)
                {
                    db.Books.Remove(book);
                    db.SaveChanges();
                }
            }
        }
        static void Main()
        {
            var bookOfLongestName = GetBooks()
                    .Where(book => book.Title.Length == GetBooks().Max(b => b.Title.Length));
            foreach (var item in bookOfLongestName)
            {
                Console.WriteLine(item.Title);
            }
            
        }
    }
}
