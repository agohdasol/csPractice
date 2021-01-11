using System;
using System.Diagnostics;
using System.Reflection;
using System.Configuration;
using System.Net;
using System.IO;
using System.Text;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Specialized;

namespace Ch14
{
  class Program
  {
    private static int RunAndWaitNotePad()
    {
      var path = @"%SystemRoot%\system32\notepad.exe";
      var fullpath = Environment.ExpandEnvironmentVariables(path);
      using var process = Process.Start(fullpath);
      if (process.WaitForExit(10000))
        return process.ExitCode;
      throw new TimeoutException();
    }
    private static void RunNotepadMaximized()
    {
      var path = @"%SystemRoot%\system32\notepad.exe";
      var fullpath = Environment.ExpandEnvironmentVariables(path);
      var startInfo = new ProcessStartInfo
      {
        FileName = fullpath,
        Arguments = @"D:\csPractice\PracticalCS\Ch14\sample.txt",
        UseShellExecute=true,
        WindowStyle = ProcessWindowStyle.Maximized
      };
      Console.WriteLine(startInfo.WindowStyle);
      Process.Start(startInfo);
    }
    private static void RunWindowsWavFile()
    {
      var startInfo = new ProcessStartInfo
      {
        FileName = @"C:\Windows\Media\Alarm01.wav",
        WindowStyle = ProcessWindowStyle.Normal,
        UseShellExecute = true,
        Verb = "Play",
      };
      Process.Start(startInfo);
    }
    private static void GetAssemblyVersion()
    {
      var asm = Assembly.GetExecutingAssembly();
      var ver = asm.GetName().Version;
      Console.WriteLine("{0} {1} {2} {3}", ver.Major, ver.Minor,ver.Build,ver.Revision);
    }
    private static void GetFileVersion()
    {
      var location = Assembly.GetExecutingAssembly().Location;
      var ver = FileVersionInfo.GetVersionInfo(location);
      Console.WriteLine("{0} {1} {2} {3}", ver.FileMajorPart, ver.FileMinorPart, ver.FileBuildPart, ver.FilePrivatePart);
    }
    private static void WebRead()
    {
      var wc = new WebClient();
      using var stream = wc.OpenRead(@"http://wikibook.co.kr/list/");
      using var sr = new StreamReader(stream, Encoding.UTF8);
      string html = sr.ReadToEnd();
      Console.WriteLine(html);
    }
    private static void GetWetherReport()
    {
      using var wc = new WebClient();
      wc.Headers.Add("Content-type", "charset=UTF-8");
      var uriString = @"http://www.kma.go.kr/weather/forecast/mid-term-rss3.jsp?stnId=109";
      var url = new Uri(uriString);
      var stream = wc.OpenRead(url);
      XDocument xdoc = XDocument.Load(stream);
      var nodes = xdoc.Root.Descendants("location");

      XElement xprovince = nodes.Elements("province").ElementAt(0);
      Console.WriteLine("[[ " + xprovince.Value + " ]]");

      foreach (var node in nodes)
      {
        XElement xcity = node.Element("city");
        Console.WriteLine("<" + xcity.Value + ">");

        var xdatas = node.Elements("data");
        foreach(var xwether in xdatas)
        {
          XElement xtmEf = xwether.Element("xtmEf");
          XElement xwf = xwether.Element("wf");
          XElement xtmn = xwether.Element("tmn");
          XElement xtmx = xwether.Element("tmx");

          Console.WriteLine("시각: ", xtmEf.Value);
          Console.WriteLine("날씨: ", xwf.Value);
          Console.WriteLine("최저기온: ", xtmn.Value);
          Console.WriteLine("최고기온: ", xtmx.Value);
        }
        Console.WriteLine();
      }
    }
    private static void GetFromWiki()
    {
      var wc = new WebClient();
      wc.QueryString = new NameValueCollection()
      {
        ["action"] = "query",
        ["prop"] = "revisions",
        ["rvprop"] = "content",
        ["format"] = "xml",
        ["titles"] = WebUtility.UrlEncode("경복궁"),
      };
      wc.Headers.Add("Content-type", "charset=UTF-8");
      var result = wc.DownloadString("http://ko.wikipedia.org/w/api.php");
      var xmldoc = XDocument.Parse(result);
      var rev = xmldoc.Root.Descendants("rev").FirstOrDefault();
      Console.WriteLine((WebUtility.HtmlDecode(rev?.Value)) ?? "찾을 수 없습니다");
    }
    private static void GetTime()
    {
      var now = DateTimeOffset.Now;
      Console.WriteLine("Now = {0}", now);
      var utc = now.ToUniversalTime();
      Console.WriteLine("UTC = {0}", utc);
      var localtime = utc.ToLocalTime();
      Console.WriteLine("LocalTime = {0}", localtime);
    }
    static void Main()
    {
      //GetTime();
      GetFromWiki();
    }
  }
}
