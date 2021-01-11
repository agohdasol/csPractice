using System;
using System.Linq;

namespace Ex15
{
  class Program
  {
    static void Ex1_2()
    {
      var maxPrice = Library.Books
        .Max(book => book.Price);
      var maxPriceBooks = Library.Books
        .Where(book => book.Price == maxPrice);
      foreach(var book in maxPriceBooks)
        Console.WriteLine(book);
    }
    static void Ex1_3()
    {
      var groups = Library.Books
        .GroupBy(b => b.PublishedYear)
        .OrderBy(b => b.Key);
      foreach(var group in groups)
        Console.WriteLine($"{group.Key}년 {group.Count()}");
    }
    static void Ex1_4()
    {
      var books = Library.Books
        .OrderByDescending(b => b.PublishedYear)
        .ThenByDescending(b => b.Price);
      foreach(var book in books)
        Console.WriteLine(book);
    }
    static void Ex1_5()
    {
      var booksOf2016 = Library.Books
        .Where(b => b.PublishedYear == 2016)
        .Join(Library.Categories,
              b => b.CategoryId,
              c => c.Id,
              (b, c) => c.Name)
        .Distinct();
      foreach(var c in booksOf2016)
        Console.WriteLine(c);
    }
    static void Ex1_6()
    {
      var groups = Library.Books
        .Join(Library.Categories,
              b => b.CategoryId,
              c => c.Id,
              (b, c) => new
              {
                Category = c.Name,
                Title = b.Title,
              })
        .GroupBy(b => b.Category)
        .OrderBy(b => b.Key);
      foreach(var group in groups)
      {
        Console.WriteLine(group.Key);
        foreach(var book in group)
          Console.WriteLine(book.Title);
      }
    }
    static void Ex1_7()
    {
      var dev = Library.Categories.Single(c => c.Name == "Development").Id;
      var groups = Library.Books
        .Where(b => b.CategoryId == dev)
        .GroupBy(b => b.PublishedYear)
        .OrderBy(b => b.Key);
      foreach(var group in groups)
      {
        Console.WriteLine(group.Key);
        foreach(var book in group)
          Console.WriteLine(book);
      }
    }
    static void Ex1_8()
    {
      var groups = Library.Categories
        .GroupJoin(Library.Books,
                    c => c.Id,
                    b => b.CategoryId,
                    (c, b) => new
                    {
                      Category = c.Name,
                      Count = b.Count(),
                    })
        .Where(g => g.Count >= 4);
      foreach(var group in groups)
        Console.WriteLine(group.Category);
    }
    static void Main(string[] args)
    {
      Ex1_8();
    }
  }
}
