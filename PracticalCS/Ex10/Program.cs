using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace Ex10
{
    class Program
    {
        //10.1
        public static bool IsPhoneNumber(string strNumber)
        {
            string pattern = @"(0[789]0)-(\d{4,})-(\d{4,})";
            return Regex.IsMatch(strNumber, pattern);
        }
        //10.2
        public static List<string> ReadTextFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            List<string> results = new List<string>();
            Regex regex = new Regex(@"\b\d{3,}\b");
            foreach (var line in lines)
            {
                var matches = regex.Matches(line);
                foreach (Match match in matches)
                {
                    results.Add(match.Value);
                }
            }
            return results;
        }
        //10.3
        public static int[] IndexOfTime(string[] texts)
        {
            Regex regex = new Regex(@"\btime\b", RegexOptions.IgnoreCase);
            int[] index = new int[texts.Length];
            int count = 0;
            foreach (var text in texts)
            {
                index[count++] = regex.Match(text).Index;
            }
            return index;
        }
        //10.4
        public static void UpdateTextVersion(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            var newLines = lines.Select(s => Regex.Replace(s, @"\bversion=""4\.0""", @"version=""5.0""", RegexOptions.IgnoreCase));
            //var newLines = lines.Select(s => Regex.Replace(s, @"\bversion", @"versionad", RegexOptions.IgnoreCase));
            foreach (var item in newLines)
            {
                Console.WriteLine(item);
            }
        }
        //10.5
        public static void HtmlTagToLower(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            var newLines = lines.Select(s => Regex.Replace(s, @"<(\w+)\w*?>", @"", RegexOptions.IgnoreCase));
            //var newLines = lines.Select(s => Regex.Replace(s, @"\bversion", @"versionad", RegexOptions.IgnoreCase));
            foreach (var item in newLines)
            {
                Console.WriteLine(item);
            }
        }
        static void Main()
        {
            Console.WriteLine(IsPhoneNumber("070-1234-1234"));
            Console.WriteLine(IsPhoneNumber("050-1234-1234"));
            Console.WriteLine(IsPhoneNumber("070-123-134"));
            var results = ReadTextFile("./asd.txt");
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
            var texts = new[]
            {
                "Time is money.",
                "What time is it?",
                "It will take time.",
                "We recognized the timetable.",
            };
            var index = IndexOfTime(texts);
            foreach (var item in index)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------");
            UpdateTextVersion("./asd.txt");
        }
    }
}
