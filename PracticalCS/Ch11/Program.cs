using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Ch11
{
    //11.10
    class Novelist
    {
        public string Name { get; set; }
        public string EngName { get; set; }
        public DateTime Birth { get; set; }
        public DateTime Death { get; set; }
        public IEnumerable<string> Masterpieces { get; set; }

        public IEnumerable<Novelist> ReadNovelists()
        {
            var xdoc = XDocument.Load("novelists.xml");
            var novelists = xdoc.Root.Elements()
                                    .Select(x => new Novelist
                                    {
                                        Name = (string)x.Element("name"),
                                        EngName = (string)x.Element("name").Attribute("eng"),
                                        Birth = (DateTime)x.Element("birth"),
                                        Death = (DateTime)x.Element("death"),
                                        Masterpieces = x.Element("masterpieces")
                                                        .Elements("title")
                                                        .Select(title => title.Value)
                                                        .ToArray()
                                    });
            return novelists.ToArray();
        }
    }
    class Program
    {
        //11.2, 3, 4, 5, 6, 7
        public static void Ex2to7(XDocument xdoc)
        {
            var xelements = xdoc.Root.Elements();
            var xnovelists = xelements.Where(x => ((DateTime)x.Element("birth")).Year <= 1900)
                                        .OrderBy(x => (string)x.Element("name").Attribute("eng"));
            foreach (var xnovelist in xnovelists)
            {
                XElement xname = xnovelist.Element("name");
                var birth = (DateTime)xnovelist.Element("birth");
                XAttribute xeng = xname.Attribute("eng");
                var works = xnovelist.Element("masterpieces")
                                    .Elements("title")
                                    .Select(x => x.Value);
                Console.WriteLine("{0}({2}) {1} - {3}", xname.Value, birth.ToShortDateString(), xeng?.Value, string.Join(", ", works));
            }
        }
        //11.9
        public static void Ex9(XDocument xdoc)
        {
            var novelists = xdoc.Root.Elements()
                                    .Select(x => new
                                    {
                                        Name = (string)x.Element("name"),
                                        Birth = (DateTime)x.Element("birth"),
                                        Death = (DateTime)x.Element("death"),
                                    });
            foreach (var novelist in novelists)
            {
                Console.WriteLine("{0} ({1}-{2})", novelist.Name, novelist.Birth.Year, novelist.Death.Year);
            }
        }
        public static void Ex14()
        {
            var novelists = new List<Novelist>
            {
                new Novelist
                {
                    Name="마크 트웨인",
                    EngName="Mark Twain",
                    Birth=DateTime.Parse("1835-11-30"),
                    Death=DateTime.Parse("1910-03-21"),
                    Masterpieces=new string[]{"톰 소여의 모험", "허클베리 핀의 모험",},

                },
                new Novelist
                {
                    Name="어니스트 헤밍웨이",
                    EngName="Ernest Hemingway",
                    Birth=DateTime.Parse("1899-07-21"),
                    Death=DateTime.Parse("1961-07-02"),
                    Masterpieces=new string[]{"무기여 잘 있거라", "노인과 바다",},
                },
            };
            var elements = novelists.Select(x =>
                      new XElement("novelist",
                          new XElement("name", x.Name, new XAttribute("eng", x.EngName)),
                          new XElement("birth", x.Birth),
                          new XElement("death", x.Death),
                          new XElement("masterpieces", x.Masterpieces.Select(t => new XElement("title", t)))
            ));
            var root = new XElement("novelists", elements);
            var xdoc = new XDocument(root);
        }
        public static void Ex22()
        {
            var option = new XElement("option");
            option.SetElementValue("enabled", true);
            option.SetElementValue("min", 0);
            option.SetElementValue("max", 100);
            option.SetElementValue("step", 10);
            var root = new XElement("settings", option);
            root.Save("sample.xml");
        }
        static void Main()
        {

            //var xdoc = XDocument.Load("novelists.xml");
            
        }
    }
}
