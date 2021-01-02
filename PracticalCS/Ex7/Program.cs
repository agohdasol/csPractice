using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ex7
{
    class Abbreviations
    {
        private Dictionary<string, string> _dict = new Dictionary<string, string>();
        //7.2 - 1
        public int Count
        {
            get
            {
                return _dict.Count;
            }
        }
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
        public IEnumerable<KeyValuePair<string, string>> FindAll(string substring)
        {
            foreach (var item in _dict)
            {
                if (item.Value.Contains(substring))
                    yield return item;
            }
        }
        //7.2 - 2
        public bool Remove(string abbr)
        {
            if (_dict.ContainsKey(abbr))
            {
                _dict.Remove(abbr);
                return true;
            }
            else
                return false;
        }
        public void Read3Abbreviations()
        {
            foreach (var item in _dict)
            {
                if(item.Key.Length==3)
                    Console.WriteLine($"{item.Key}={item.Value}");
            }
        }
    }
    class Program
    {
        static void Main()
        {
            //7.1
            string line = "Cozy lummox gives smart squid who asks for job pen";
            //7.1 - 1
            var alphabetDict = new Dictionary<char, int>();
            foreach (var item in line)
            {
                var uc = char.ToUpper(item);
                if ('A' <= uc && uc <= 'Z')
                {
                    if (alphabetDict.ContainsKey(uc))
                        alphabetDict[uc]++;
                    else
                        alphabetDict[uc] = 1;
                }

            }
            foreach (var item in alphabetDict)
                Console.WriteLine($"{item.Key} : {item.Value}");
            Console.WriteLine("------");
            //7.1 - 2
            var sortedDict = new SortedDictionary<char, int>();
            foreach (var item in line)
            {
                var uc = char.ToUpper(item);
                if ('A' <= uc && uc <= 'Z')
                {
                    if (sortedDict.ContainsKey(uc))
                        sortedDict[uc]++;
                    else
                        sortedDict[uc] = 1;
                }

            }
            foreach (var item in sortedDict)
                Console.WriteLine($"{item.Key} : {item.Value}");
            Console.WriteLine("------");
            //7.2
            //7.2 - 3
            Abbreviations abbrs = new Abbreviations();
            Console.WriteLine(abbrs.Count);
            Console.WriteLine("------");
            if (abbrs.Remove("ILO")==true)
                Console.WriteLine(abbrs.Count);
            Console.WriteLine("------");
            //7.2 - 4
            abbrs.Read3Abbreviations();
        }
    }
}
