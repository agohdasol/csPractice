using System.Runtime.Serialization;
using System.Xml;
using System;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Collections.Generic;

namespace Ch12
{
    [XmlRoot("novel")]
    public class Novel
    {
        [XmlElement(ElementName ="title")]
        public string Title { get; set; }
        [XmlElement(ElementName = "author")]
        public string Author { get; set; }
        [XmlElement(ElementName = "published")]
        public int Published { get; set; }
        public override string ToString()
        {
            return string.Format("[Title={0}, Author={1}, Published={2}]",
                Title, Author, Published);
        }
    }
    [XmlRoot("novels")]
    public class NovelCollection
    {
        [XmlElement(Type =typeof(Novel), ElementName ="novel")]
        public Novel[] Novels { get; set; }
    }
    [DataContract(Name ="novel")]
    public class NovelJson
    {
        [DataMember(Name = "title")]
        public string Title { get; set; }
        [DataMember(Name = "author")]
        public string Author { get; set; }
        [DataMember(Name = "published")]
        public int Published { get; set; }
        public override string ToString()
        {
            return string.Format("[Title={0}, Author={1}, Published={2}]",
                Title, Author, Published);
        }
    }
    [DataContract]
    public class AbbreviationDict
    {
        [DataMember(Name ="abbrs")]
        public Dictionary<string, string> Abbreviations { get; set; }
    }
    class Program
    {
        public static void Ex2()
        {
            var novel = new Novel[]
            {
                new Novel
                {
                    Author = "제임스 P. 호건",
                    Title = "별의 계승자",
                    Published = 1977,
                },
                new Novel
                {
                    Author = "허버트 조지 웰즈",
                    Title = "타임머신",
                    Published = 1895,
                },
            };
            var settings = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "  ",
            };
            using var writer = XmlWriter.Create("novel.xml", settings);
            var serializer = new DataContractSerializer(novel.GetType());
            serializer.WriteObject(writer, novel);
        }
        public static void Ex3()
        {
            using var reader = XmlReader.Create("novel.xml");
            var serializer = new DataContractSerializer(typeof(Novel));
            var novel = serializer.ReadObject(reader) as Novel;
            Console.WriteLine(novel);
        }
        public static void Ex6()
        {
            var novel = new Novel[]
            {
                new Novel
                {
                    Author = "제임스 P. 호건",
                    Title = "별의 계승자",
                    Published = 1977,
                },
                new Novel
                {
                    Author = "허버트 조지 웰즈",
                    Title = "타임머신",
                    Published = 1895,
                },
            };
            var settings = new XmlWriterSettings
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "  ",
            };
            using var writer = XmlWriter.Create("novel.xml", settings);
            var serializer = new XmlSerializer(novel.GetType());
            serializer.Serialize(writer, novel);
        }
        public static void Ex11()
        {
            var novels = new Novel[]
            {
                new Novel
                {
                    Author = "제임스 P. 호건",
                    Title = "별의 계승자",
                    Published = 1977,
                },
                new Novel
                {
                    Author = "허버트 조지 웰즈",
                    Title = "타임머신",
                    Published = 1895,
                },
            };
            var novelCollection = new NovelCollection
            {
                Novels = novels
            };
            using var writer = XmlWriter.Create("novels.xml");
            var serializer = new XmlSerializer(novelCollection.GetType());
            serializer.Serialize(writer, novelCollection);
        }
        public static void Ex14()
        {
            var novels = new Novel[]
            {
                new Novel
                {
                    Author = "제임스 P. 호건",
                    Title = "별의 계승자",
                    Published = 1977,
                },
                new Novel
                {
                    Author = "허버트 조지 웰즈",
                    Title = "타임머신",
                    Published = 1895,
                },
            };
            using var stream = new FileStream("novels.json", FileMode.Create, FileAccess.Write);
            var serializer = new DataContractJsonSerializer(novels.GetType());
            serializer.WriteObject(stream, novels);
        }
        public static void Ex17()
        {
            var abbreviationDict = new AbbreviationDict
            {
                Abbreviations = new Dictionary<string, string>
                {
                    ["ODA"] = "정부개발원조",
                    ["OECD"] = "경제 협력 개발 기구",
                    ["OPEC"] = "석유 수출국 기구",
                }
            };
            var settings = new DataContractJsonSerializerSettings
            {
                UseSimpleDictionaryFormat = true,
            };
            using var stream = new FileStream("abbreviations.json", FileMode.Create, FileAccess.Write);
            var serializer = new DataContractJsonSerializer(abbreviationDict.GetType(), settings);
            serializer.WriteObject(stream, abbreviationDict);
        }
        public static void Ex18()
        {
            var settings= new DataContractJsonSerializerSettings
            {
                UseSimpleDictionaryFormat = true,
            };
            using var stream = new FileStream("abbreviations.json", FileMode.Open, FileAccess.Read);
            var serializer = new DataContractJsonSerializer(typeof(AbbreviationDict), settings);
            var dict = serializer.ReadObject(stream) as AbbreviationDict;
            foreach (var item in dict.Abbreviations)
            {
                Console.WriteLine("{0} {1}", item.Key, item.Value);
            }
        }
        static void Main()
        {
            
        }
    }
}
