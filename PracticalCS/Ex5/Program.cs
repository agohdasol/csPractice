using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex5
{
    class Program
    {
        public static string TextConverter(string input)
        {
            string[] strArray = input.Split(';');
            var sb = new StringBuilder();
            foreach (var item in strArray)
            {
                string[] devided = item.Split('=');
                switch (devided[0])
                {
                    case "Novelist":
                        sb.Append($"작가 : {devided[1]}\n");
                        break;
                    case "BestWork":
                        sb.Append($"대표작 : {devided[1]}\n");
                        break;
                    case "Born":
                        sb.Append($"출판연도 : {devided[1]}\n");
                        break;
                }
            }
            return sb.ToString();
        }
        static void Main()
        {
            //5.1
            Console.Write("문자열 1 입력 : ");
            string input1 = Console.ReadLine();
            Console.Write("문자열 2 입력 : ");
            string input2 = Console.ReadLine();
            Console.WriteLine(string.Compare(input1, input2, true));

            //5.2
            Console.Write("숫자 입력 : ");
            string inputInt = Console.ReadLine();
            if (Int32.TryParse(inputInt, out int number))
            {
                string joinedStr = string.Join(", ", number.ToString().ToCharArray());
                Console.WriteLine(joinedStr);
            }
            else
            {
                Console.WriteLine("올바르지 않은 입력");
            }

            //5.3 - 1
            string strSample = "Jackdaws love my big sphinx of quartz";
            Console.Write("공백 갯수 : ");
            Console.WriteLine(strSample.Count(s => s == ' '));
            //5.3 - 2
            Console.Write("변환문장 : ");
            Console.WriteLine(strSample.Replace("big", "small"));
            //5.3 - 3
            Console.Write("단어 갯수 : ");
            Console.WriteLine(strSample.Split(" ").Length);
            //5.3 - 4
            Console.Write("4글자 이하 단어 : ");
            string[] four = strSample.Split(" ").Where(s => s.Length <= 4).ToArray();
            Array.ForEach<string>(four, s => Console.Write($"{s}, "));
            Console.WriteLine();
            Console.Write("다른방법 : ");
            Console.WriteLine(string.Join(", ", four));
            Console.WriteLine();
            //5.3 - 5
            var sb = new StringBuilder();
            string[] split = strSample.Split(" ");
            foreach (var item in split)
            {
                sb.Append(item);
                sb.Append(" ");
            }
            //sb.Remove(-1, 1);
            var text = sb.ToString();
            Console.WriteLine(text);

            //5.4
            string sampleText = "Novelist=김만중;BestWork=구운몽;Born=1687";
            Console.WriteLine(TextConverter(sampleText));
        }
    }
}
