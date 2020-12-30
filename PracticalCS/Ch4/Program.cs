using System;
using System.Collections.Generic;
using System.Linq;

namespace Ch4
{
    class MyClass
    {
        public List<int> MyList { get; private set; }
        public MyClass()
        {
            MyList = new List<int>() { 1, 2, 3, 4, 5 };
        }
        public double Median(params double[] args)
        {
            var sorted = args.OrderBy(n => n).ToArray();
            int index = sorted.Length / 2;
            if (sorted.Length % 2 == 0)
                return (sorted[index] + sorted[index-1])/2;
            else
                return sorted[index];
        }
    }
    class Program
    {
        static void Main()
        {
            var obj = new MyClass();
            obj.MyList.Add(6);
            obj.MyList.RemoveAt(0);
            obj.MyList[0] = 10;
            foreach (var item in obj.MyList)
            {
                Console.WriteLine(item);
            }
            //obj.MyList = new List<int>();
            Console.WriteLine(obj.Median(1, 2));
            Console.ReadLine();
        }
    }
}
