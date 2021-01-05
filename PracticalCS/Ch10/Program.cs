using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ch10
{
    class Program
    {
        static void Main()
        {
            //10.1, 10.2
            var text = "private List<string> results = new List<string>();";
            bool isMatch = Regex.IsMatch(text, @"List<\w+>");
            //var regex = new Regex(@"List<\w+>");
            if (isMatch)
                Console.WriteLine("찾았습니다");
            else
                Console.WriteLine("못찾았습니다");

            //10.3
            text = "using System.Test.RegularExpressions;";
            isMatch = Regex.IsMatch(text, @"^using");
            if (isMatch)
                Console.WriteLine("using 으로 시작");
            else
                Console.WriteLine("using 으로 시작안함");

            //10.4
            text = "Regex 클래스를 사용해서 문자열 처리";
            isMatch = Regex.IsMatch(text, @"처리$");
            if (isMatch)
                Console.WriteLine("처리 로 끝남");
            else
                Console.WriteLine("처리 로 안끝남");

            //10.5
            var strings = new[] { "Microsoft Windows", "Windows Server", "Windows", };
            var regex = new Regex(@"^(W|w)indows$");
            var count = strings.Count(strings => regex.IsMatch(strings));
            Console.WriteLine("{0} 행과 일치", count);

            //10.7
            strings = new[] { "13000", "-50.6", "0.123", "+180.00", "10.2.5", "320-0831", " 123", "$1200", "500원", };
            regex = new Regex(@"^[-+]?(\d+)(\.\d+)?$");
            foreach (var item in strings)
            {
                isMatch = regex.IsMatch(item);
                if (isMatch)
                    Console.WriteLine(item);
            }

            //10.8
            text = "Regex 클래스를 사용해서 문자열 처리";
            Match match = Regex.Match(text, @"\p{IsHangulSyllables}+");
            if (match.Success)
                Console.WriteLine("{0} {1}", match.Index, match.Value);

            //10.9
            text = "private List<string> results = new List<string>();";
            var matches = Regex.Matches(text, @"List<\w+>");
            foreach (Match item in matches)
            {
                Console.WriteLine("Index={0}, Length={1}, Value={2}",
                    item.Index, item.Length, item.Value);
            }
            //10.10
            match = Regex.Match(text, @"List<\w+>");
            while (match.Success)
            {
                Console.WriteLine("Index={0}, Length={1}, Value={2}",
                    match.Index, match.Length, match.Value);
                match = match.NextMatch();
            }

            //10.11
            text = "private List<string> results = new List<string>();";
            var matchesIEnumerable = Regex.Matches(text, @"\b[a-z]+\b")
                                        .Cast<Match>()
                                        .OrderBy(x => x.Length);
            foreach (Match item in matchesIEnumerable)
            {
                Console.WriteLine("Index={0}, Length={1}, Value={2}",
                    item.Index, item.Length, item.Value);
            }

            //10.12
            text = "C#에는 <값형>과 <참조형>이라는 두 가지의 형이 존재합니다.";
            matches = Regex.Matches(text, @"<([^<>]+)>");
            foreach (Match item in matches)
            {
                Console.WriteLine("<{0}>", item.Groups[1]);
                Console.WriteLine("<{0}>", item.Groups[0]);
            }

            //10.15
            text = "C# 공부를 쪼금씩 진행해보자 조금씩 쬐끔씩";
            var pattern = @"조금씩|쪼끔씩|쪼금씩|쬐끔씩";
            var replaced = Regex.Replace(text, pattern, "조금씩");
            Console.WriteLine(replaced);

            //10.16
            text = "Word, Excel ,PowerPoint , Outlook,Onenote";
            pattern = @"\s*,\s*";
            replaced = Regex.Replace(text, pattern, ", ");
            Console.WriteLine(replaced);

            //10.17
            text = "foo.htm bar.html baz.htm";
            pattern = @"\.(htm)\b";
            replaced = Regex.Replace(text, pattern, ".html");
            Console.WriteLine(replaced);

            //10.18
            text = "1024바이트, 8바이트 문자, 바이트, 킬로바이트";
            pattern = @"(\d+)바이트";
            replaced = Regex.Replace(text, pattern, "$1byte");
            Console.WriteLine(replaced);

            //10.19
            text = "1234567890123456";
            pattern = @"(\d{4})(\d{4})(\d{4})(\d{4})";
            replaced = Regex.Replace(text, pattern, "$1-$2-$3-$4");
            Console.WriteLine(replaced);

            //10.20
            text = "Word, Excel ,PowerPoint , Outlook,Onenote";
            pattern = @"\s*,\s*";
            string[] substrings = Regex.Split(text, pattern);
            foreach (var item in substrings)
            {
                Console.WriteLine("'{0}'", item);
            }

            //10.21
            text = "a12346 b123 Z12345 AX98765";
            pattern = @"\b[a-zA-Z]{2,}[0-9]{5,}\b";
            matches = Regex.Matches(text, pattern);
            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }

            //10.23
            text = "<person><name>김삿갓</name><age>22</age></person>";
            pattern = @"<.+>";
            matches = Regex.Matches(text, pattern);
            foreach (Match item in matches)
            {
                Console.WriteLine("'{0}'", item.Value);
            }
            //10.24
            text = "<person><name>김삿갓</name><age>22</age></person>";
            pattern = @"<(\w[^>]+)>";
            matches = Regex.Matches(text, pattern);
            foreach (Match item in matches)
            {
                Console.WriteLine("'{0}'", item.Value);
                Console.WriteLine("'{0}'", item.Groups[1].Value);
            }
            //10.25
            text = "<person><name>김삿갓</name><age>22</age></person>";
            pattern = @"<(\w+?)>";
            matches = Regex.Matches(text, pattern);
            foreach (Match item in matches)
            {
                Console.WriteLine("'{0}'", item.Groups[1].Value);
            }

            //10.26
            text = "<p>가나다라마</p><p>바사아자차</p>";
            pattern = @"<p>(.*?)</p>";
            matches = Regex.Matches(text, pattern);
            foreach (Match item in matches)
            {
                Console.WriteLine("'{0}'", item.Groups[1].Value);
            }

            //10.27
            text = "도로를 지나가는 차들이 뛰뛰하고 경적을 울리면 반대쪽 차들이 빵빵하고 울린다.";
            pattern = @"(\w)\1";
            matches = Regex.Matches(text, pattern);
            foreach (Match item in matches)
            {
                Console.WriteLine("'{0}'", item.Value);
            }
            //10.28
            text = "기러기 펠리컨 청둥오리 오리너구리 토마토 pops push pop";
            pattern = @"\b(\w)\w\1\b";
            matches = Regex.Matches(text, pattern);
            foreach (Match item in matches)
            {
                Console.WriteLine("'{0}'", item.Value);
            }
        }
    }
}
