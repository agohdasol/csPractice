using System;
using System.Collections.Generic;
using System.Linq;

namespace Ch15
{
  class Category
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public override string ToString()
    {
      return $"Id:{Id}, 분야 이름:{Name}";
    }
  }
  public class Book
  {
    public string Title { get; set; }
    public int Price { get; set; }
    public int CategoryId { get; set; }
    public int PublishedYear { get; set; }
    public override string ToString()
    {
      return $"발행연도:{PublishedYear}, 분야:{CategoryId}, 가격:{Price}, 제목:{Title}";
    }
  }
  static class Library
  {
    public static IEnumerable<Category> Categories { get; private set; }
    public static IEnumerable<Book> Books { get; private set; }
    static Library()
    {
      Categories = new List<Category> {
                new Category { Id = 1, Name = "Development"  },
                new Category { Id = 2, Name = "Server"  },
                new Category { Id = 3, Name = "Web Design"  },
                new Category { Id = 4, Name = "Windows"  },
                new Category { Id = 5, Name = "Application"  },
            };

      Books = new List<Book> {
                new Book { Title = "Writing C# Solid Code", CategoryId = 1, Price = 25000, PublishedYear = 2016 },
                new Book { Title = "C# 개발지침", CategoryId = 1, Price = 38000, PublishedYear = 2014 },
                new Book { Title = "Visual C# 다시 입문", CategoryId = 1, Price = 27800, PublishedYear = 2016 },
                new Book { Title = "구문으로 배우는 C# Book", CategoryId = 1, Price = 24000, PublishedYear = 2016 },
                new Book { Title = "TypeScript 초급 강좌", CategoryId = 1, Price = 25000, PublishedYear = 2015 },
                new Book { Title = "PowerShell 실전 레시피", CategoryId = 2, Price = 42000, PublishedYear = 2013 },
                new Book { Title = "SQL Server 완전 입문", CategoryId = 2, Price = 38000, PublishedYear = 2014 },
                new Book { Title = "IIS 웹 서버 운용 가이드", CategoryId = 2, Price = 31800, PublishedYear = 2015 },
                new Book { Title = "마이크로소프트 Azure 서버 구축", CategoryId = 2, Price = 48000, PublishedYear = 2016 },
                new Book { Title = "웹 디자인 강좌 HTML5 & CSS", CategoryId = 3, Price = 28000, PublishedYear = 2013 },
                new Book { Title = "HTML5 웹 대백과", CategoryId = 3, Price = 38000, PublishedYear = 2015 },
                new Book { Title = "CSS 디자인 사전", CategoryId = 3, Price = 35500, PublishedYear = 2015 },
                new Book { Title = "Windows10으로 즐겁게 일하기", CategoryId = 4, Price = 22800, PublishedYear = 2016 },
                new Book { Title = "Windows10의 고수가 되는 법", CategoryId = 4, Price = 18900, PublishedYear = 2015 },
                new Book { Title = "Windows10의 고수가 되는 법2", CategoryId = 4, Price = 20800, PublishedYear = 2016 },
                new Book { Title = "Windows10 쉽게 다루자 입문편", CategoryId = 4, Price = 23000, PublishedYear = 2015 },
                new Book { Title = "너무 쉬운 Windows10 입문", CategoryId = 5, Price = 18900, PublishedYear = 2015 },
                new Book { Title = "Word Excel 실전 템플레이트 모음집", CategoryId = 5, Price = 26000, PublishedYear = 2016 },
                new Book { Title = "즐겁게 배우는 Excel 초급편", CategoryId = 5, Price = 28000, PublishedYear = 2015 },
            };
    }
  }
  class Program
  {
    static void Ex15_2()
    {
      var price = Library.Books
        .Where(b => b.CategoryId == 1)
        .Max(b => b.Price);
      Console.WriteLine(price);
    }
    static void Ex15_3()
    {
      var min = Library.Books
        .Min(x => x.Title.Length);
      var book = Library.Books
        .First(book => book.Title.Length == min);
      Console.WriteLine(book);

    }
    static void Ex15_4()
    {
      var average = Library.Books.Average(x => x.Price);
      var aboves = Library.Books.Where(b => b.Price > average);
      foreach(var book in aboves)
      {
        Console.WriteLine(book);
      }
    }
    static void Ex15_5()
    {
      var query = Library.Books
        .Select(b => b.PublishedYear)
        .Distinct()
        .OrderBy(y => y);
      Console.WriteLine(query);
    }
    static void Ex15_6()
    {
      var books = Library.Books
        .OrderBy(b => b.CategoryId)
        .ThenByDescending(b => b.PublishedYear);
      foreach(var book in books)
        Console.WriteLine(book);
    }
    static void Ex15_7()
    {
      var years = new int[] { 2013, 2016 };
      var books = Library.Books.Where(b => years.Contains(b.PublishedYear));
      foreach(var book in books)
        Console.WriteLine(book);
    }
    static void Ex15_8()
    {
      var groups = Library.Books
        .GroupBy(b => b.PublishedYear)
        .OrderBy(g => g.Key);
      Console.WriteLine(groups.GetType());
      foreach(var g in groups)
      {
        Console.WriteLine($"{g.Key}년");
        foreach(var book in g)
          Console.WriteLine($" {book}");
      }
    }
    static void Ex15_9()
    {
      var groups = Library.Books
        .GroupBy(b => b.PublishedYear)
        .Select(group=>group.OrderByDescending(b=>b.Price).First())
        .OrderBy(o => o.PublishedYear);
      foreach (var g in groups)
        Console.WriteLine(g);
    }
    static void Ex15_10()
    {
      var lookup = Library.Books
        .ToLookup(b => b.PublishedYear);
      var books = lookup[2014];
      foreach(var book in books)
        Console.WriteLine(book);
    }
    static void Ex15_11()
    {
      var books = Library.Books
        .OrderBy(b => b.CategoryId)
        .ThenBy(b => b.PublishedYear)
        .Join(Library.Categories,
              book => book.CategoryId,
              category => category.Id,
              (book, category) => new
              {
                Title = book.Title,
                Category = category.Name,
                PublishedYear = book.PublishedYear
              });
      foreach(var book in books)
      {
        Console.WriteLine(book);
      }
    }
    static void Ex15_12()
    {
      var names = Library.Books
        .Where(b => b.PublishedYear == 2016)
        .Join(Library.Categories,
              book => book.CategoryId,
              category => category.Id,
              (book, category) => category.Name)
        .Distinct();
      foreach(var name in names)
        Console.WriteLine(name);
    }
    static void Ex15_13()
    {
      var groups = Library.Categories
        .GroupJoin(Library.Books,
        c => c.Id,
        b => b.CategoryId,
        (c, b) => new { Category = c.Name, Books = b });
      foreach(var group in groups)
      {
        Console.WriteLine(group.Category);
        foreach(var book in group.Books)
          Console.WriteLine(book);
      }
    }
    static void Main()
    {
      Ex15_13();
    }
  }
}
