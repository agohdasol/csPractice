using System;
using Ex1_1_test;

namespace Ex1_1_test
{
    public class Product
    {
        public int Code { get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }

        public Product(int code, string name, int price)
        {
            this.Code = code;
            this.Name = name;
            this.Price = price;
        }
        public int GetTax()
        {
            return (int)(Price * 0.08);
        }
        public int GetPriceIncludingTax()
        {
            return Price + GetTax();
        }
    }
}

namespace Ex1_1
{
    class Program
    {
        static void Main()
        {
            Product pulbbang = new Product(98, "풀빵", 210);
            Console.WriteLine(pulbbang.GetPriceIncludingTax());
        }
    }
}
