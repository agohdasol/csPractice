using System;
using System.Collections.Generic;
using System.IO;

namespace Ch2_2
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
        private List<Sale> _sales;
#pragma warning restore IDE0044 // 읽기 전용 한정자 추가

        public SalesCounter(List<Sale> sales)
        {
            _sales = sales;
        }
        public SalesCounter(string filePath)
        {
            _sales = ReadSales(filePath);
        }
        public Dictionary<string, int> GetPerStoreSales()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales)
            {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                else
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }
        static List<Sale> ReadSales(string filePath)
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
            SalesCounter sales = new SalesCounter("sales.csv");
            Dictionary<string, int> amountPerStore = sales.GetPerStoreSales();
            foreach(KeyValuePair<string, int> obj in amountPerStore)
            {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }
        }
    }
}
