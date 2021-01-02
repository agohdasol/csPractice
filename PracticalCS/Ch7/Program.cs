using System.Collections.Generic;
using System.Linq;
using System;
using System.IO;

namespace Ch7
{
    class Abbreviations
    {
        private Dictionary<string, string> _dict = new Dictionary<string, string>();
        public Abbreviations()
        {
            var lines = File.ReadAllLines("Abbreviations.txt");
            _dict = lines.Select(line => line.Split('='))
                .ToDictionary(x => x[0], x => x[1]);
        }
        public void Add(string abbr, string korean)
        {
            _dict[abbr] = korean;
        }
        public string this[string abbr]
        {
            get
            {
                return _dict.ContainsKey(abbr) ? _dict[abbr] : null;
            }
        }
        public string ToAbbreviation(string korean)
        {
            return _dict.FirstOrDefault(x => x.Value == korean).Key;
        }
        public IEnumerable<KeyValuePair<string,string>> FindAll(string substring)
        {
            foreach (var item in _dict)
            {
                if (item.Value.Contains(substring))
                    yield return item;
            }
        }
    }
    class Employee
    {
        public int Number;
        public string Name;
        public Employee(int number, string name)
        {
            this.Number = number;
            this.Name = name;
        }
    }
    class MonthDay
    {
        public int Day { get; private set; }
        public int Month { get; private set; }
        public MonthDay(int month, int day)
        {
            this.Month = month;
            this.Day = day;
        }
        public override bool Equals(object obj)
        {
            var other = obj as MonthDay;
            if (other == null)
                throw new ArgumentException();
            return this.Day == other.Day && this.Month == other.Month;
        }
        public override int GetHashCode()
        {
            return Month.GetHashCode() * 31 + Day.GetHashCode();
        }
    }
    class WordsExtractor
    {
        private string[] _lines;
        public WordsExtractor(string[] lines)
        {
            _lines = lines;
        }
        public IEnumerable<string> Extract()
        {
            var hash = new HashSet<string>();
            foreach (var line in _lines)
            {
                var words = GetWords(line);
                foreach (var word in words)
                {
                    if (word.Length >= 10)
                        hash.Add(word.ToLower());
                }
            }
            return hash.OrderBy(s => s);
        }
        private char[] _seperators = @" !?"",.".ToCharArray();
        private IEnumerable<string> GetWords(string line)
        {
            var items = line.Split(_seperators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in items)
            {
                var index = item.IndexOf("'");
                var word = index <= 0 ? item : item.Substring(0, index);
                if (word.ToLower().All(c => 'a' <= c && c <= 'z'))
                    yield return word;
            }
        }
    }
    class Program
    {
        static void Main()
        {
            var flowerDict = new Dictionary<string, int>()
            {
                ["sunflower"] = 400,
                ["pansy"] = 300,
                ["tulip"] = 350,
                ["rose"] = 500,
                ["dahlia"] = 450,
            };
            var employeeDict = new Dictionary<int, Employee>
            {
                [100] = new Employee(100, "김이박"),
                [101] = new Employee(101, "최정강"),
            };
            flowerDict["violet"] = 600;
            employeeDict[126] = new Employee(126, "김향단");
            flowerDict.Add("vivian", 342);
            employeeDict.Add(123, new Employee(123, "이몽룡"));
            int price = flowerDict["vivian"];
            var employee = employeeDict[126];
            var key = "pansy";
            if (flowerDict.ContainsKey(key))
            {
                price = flowerDict[key];
                flowerDict.Remove("pansy");
            }
            flowerDict.Average(x => x.Value);
            var employeeList = new List<Employee>()
            {
                new Employee(134, "임임"),
                new Employee(143, "박박"),
            };
            var employeeToDict = employeeList.ToDictionary(emp => emp.Number);
            var newDict = flowerDict.Where(x => x.Value >= 400)
                .ToDictionary(flower => flower.Key, flower => flower.Value);

            var dict = new Dictionary<MonthDay, string>
            {
                { new MonthDay(6,6), "현충일" },
                { new MonthDay(8,15), "광복절" },
                { new MonthDay(10,3), "개천절" },
            };
            var md = new MonthDay(8, 15);
            var s = dict[md];
            Console.WriteLine(s);

            //7.3
            var abbrs = new Abbreviations();
            abbrs.Add("IOC", "국제 올림픽 위원회");
            abbrs.Add("NPT", "핵확산방지조약");
            var names = new[] { "WHO", "FIFA", "NPT", };
            Console.WriteLine(names);
            foreach (var name in names)
            {
                var fullname = abbrs[name];
                if (fullname == null)
                    Console.WriteLine("{0}을 찾을 수 없습니다", name);
                else
                    Console.WriteLine("{0}={1}", name, fullname);
            }
            Console.WriteLine();
            var korean = "동남아시아 국가 연합";
            var abbreviation = abbrs.ToAbbreviation(korean);
            if (abbreviation == null)
                Console.WriteLine("{0}을 찾을 수 없습니다", korean);
            else
                Console.WriteLine("{0}의 줄임말은 {1}입니다", korean, abbreviation);
            Console.WriteLine();
            foreach(var item in abbrs.FindAll("국제"))
            {
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }
            Console.WriteLine();
        }
    }
}
