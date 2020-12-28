using System;
using System.Collections.Generic;
using System.IO;

namespace Ex2_3
{
    public class Sale
    {
        public string ShopName { get; set; }
        public string ProductCategory { get; set; }
        public int Amount { get; set; }
    }
    public class SalesCounter
    {
#pragma warning disable IDE0044 // 읽기 전용 한정자 추가
        private IEnumerable<Sale> _sales;
#pragma warning restore IDE0044 // 읽기 전용 한정자 추가

        public SalesCounter(IEnumerable<Sale> sales)
        {
            _sales = sales;
        }
        public SalesCounter(string filePath)
        {
            _sales = ReadSales(filePath);
        }
        public IDictionary<string, int> GetPerStoreSales()
        {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _sales)
            {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                else
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }
        public IDictionary<string, int> GetPerCategorySales()
        {
            var dict = new Dictionary<string, int>();
            foreach (var sale in _sales)
            {
                if (dict.ContainsKey(sale.ProductCategory))
                    dict[sale.ProductCategory] += sale.Amount;
                else
                    dict[sale.ProductCategory] = sale.Amount;
            }
            return dict;
        }
        private static List<Sale> ReadSales(string filePath)
        {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Sale sale = new Sale
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }
    }
    class Program
    {
        static void Main()
        {
            var sales = new SalesCounter("sales.csv");
            var amountPerCategory = sales.GetPerCategorySales();
            foreach (var obj in amountPerCategory)
            {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }
        }
    }
}
