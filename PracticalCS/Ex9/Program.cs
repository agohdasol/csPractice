using System;
using System.IO;
using System.Linq;

namespace Ex9
{
    class Program
    {
        //9.1 - 1
        public static int CountClass(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (var reader = new StreamReader(filePath))
                {
                    int counter = 0;
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (line.Contains(" class "))
                            counter++;
                    }
                    return counter;
                }
            }
            return 0;
        }
        //9.1 - 2
        public static int CountClassAllLines(string filePath)
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                int counter = 0;
                foreach (var line in lines)
                {
                    if (line.Contains(" class "))
                        counter++;
                }
                return counter;
            }
            return 0;
        }
        //9.1 - 3
        public static int CountClassLines(string filePath)
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadLines(filePath);
                int counter = 0;
                foreach (var line in lines)
                {
                    if (line.Contains(" class "))
                        counter++;
                }
                return counter;
            }
            return 0;
        }
        //9.2
        public static void AddIndexOfFile(string filePath)
        {
            var lines = File.ReadLines(filePath)
                            .Select((s, n) => string.Format("{0} : {1}", n + 1, s));
            var newFilePath = Path.ChangeExtension(filePath, ".txt");
            File.WriteAllLines(newFilePath, lines);
        }
        public static void AddAfterEndOfLines(string toFilePath, string fromFilePath)
        {
            var lines = File.ReadAllLines(fromFilePath);
            using(var writer=new StreamWriter(toFilePath, append: true))
            {
                foreach (var line in lines)
                    writer.WriteLine(line);
            }
        }
        static void Main()
        {
            //Console.WriteLine(CountClass(@"D:\csPractice\PracticalCS\Ex9\Program.cs"));
            //Console.WriteLine(CountClassAllLines(@"D:\csPractice\PracticalCS\Ex9\Program.cs"));
            //Console.WriteLine(CountClassLines(@"D:\csPractice\PracticalCS\Ex9\Program.cs"));
            AddIndexOfFile(@"D:\csPractice\PracticalCS\Ex9\Program.cs");
        }
    }
}
