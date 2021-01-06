using System;
using System.Linq;
using System.Xml.Linq;

namespace Ex11
{
    class Program
    {
        public static void Ex1_1()
        {
            XDocument xdoc = XDocument.Load("Sample1.xml");
            var xelements = xdoc.Root.Elements("ballsport");
            foreach (var xelement in xelements)
            {
                Console.WriteLine("{0} {1}", xelement.Element("name").Value, xelement.Element("teammembers").Value);
            }
        }
        public static void Ex1_2()
        {
            XDocument xdoc = XDocument.Load("Sample1.xml");
            var xelements = xdoc.Root.Elements()
                .Select(x => new
                {
                    FirstPlayed = x.Element("firstplayed").Value,
                    Name = x.Element("name").Value,
                })
                .OrderBy(x=>x.FirstPlayed);
            foreach (var xelement in xelements)
            {
                Console.WriteLine(xelement.Name);
            }
        }
        public static void Ex1_3()
        {
            XDocument xdoc = XDocument.Load("Sample1.xml");
            var xelement_max = xdoc.Root.Elements()
                .Select(x => new
                {
                    FirstPlayed = x.Element("firstplayed").Value,
                    Name = x.Element("name").Value,
                    Teammembers=x.Element("teammembers").Value,
                })
                .OrderByDescending(x=>x.Teammembers)
                .First();
            Console.WriteLine(xelement_max.Name);
        }
        public static void Ex1_4()
        {
            var element = new XElement("ballsport",
                new XElement("name", "축구"),
                new XElement("teammembers", "11"),
                new XElement("firstplayed", "1238")
                );
            XDocument xdoc = XDocument.Load("Sample1.xml");
            xdoc.Root.Add(element);
            xdoc.Save("ex1_4");
        }
        public static void Ex2()
        {
            var xdoc = XDocument.Load("Sample2.xml");
            var words = xdoc.Root.Elements()
                                .Select(x =>
                                    new XElement("word",
                                        new XAttribute("chinese", x.Element("chinese").Value),
                                        new XAttribute("korean", x.Element("korean").Value)
                ));
            var root = new XElement("seoulku", words);
            root.Save("Ex2.xml");
        }
        static void Main()
        {
            Ex2();
        }
    }
}
