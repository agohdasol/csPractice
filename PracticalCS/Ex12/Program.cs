using System;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Ex12
{
    [XmlRoot("employee")]
    [DataContract]
    public class Employee
    {
        [XmlElement(ElementName ="id")]
        [DataMember(Name ="id")]
        public int Id { get; set; }
        [XmlElement(ElementName = "name")]
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "hiredate")]
        [DataMember(Name = "hiredate")]
        public DateTime HireDate { get; set; }
        //12.1 - 1
        public static void EmployeeSerializer()
        {
            Employee employee = new Employee
            {
                Id = 202,
                Name = "김김김",
                HireDate = new DateTime(2020, 2, 21),
            };
            using var writer = XmlWriter.Create("employees.xml");
            var serializer = new XmlSerializer(employee.GetType());
            serializer.Serialize(writer, employee);
        }
        //12.1 - 2
        public static void EmployeesSerializer()
        {
            Employee[] employees = new Employee[] { 
                new Employee
                {
                    Id = 202,
                    Name = "김김김",
                    HireDate = new DateTime(2020, 2, 21),
                },
                new Employee
                {
                    Id = 203,
                    Name = "박박박",
                    HireDate = new DateTime(2018, 5, 15),
                }
            };
            using var writer = XmlWriter.Create("employees.xml");
            var serializer = new XmlSerializer(employees.GetType());
            serializer.Serialize(writer, employees);
        }
        //12.1 - 3
        public static void EmployeesDeserializer()
        {
            using var reader = XmlReader.Create("employees.xml");
            var serializer = new XmlSerializer(typeof(Employee[]));
            var employees = serializer.Deserialize(reader) as Employee[];
            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.Id} {employee.Name} {employee.HireDate}");
            }
        }
        //12.1 - 4
        public static void EmployeesJsonSerializer()
        {
            Employee[] employees = new Employee[] {
                new Employee
                {
                    Id = 202,
                    Name = "김김김",
                    HireDate = new DateTime(2020, 2, 21),
                },
                new Employee
                {
                    Id = 203,
                    Name = "박박박",
                    HireDate = new DateTime(2018, 5, 15),
                }
            };
            using var stream = new FileStream("employees.json", FileMode.Create, FileAccess.Write);
            var serializer = new DataContractJsonSerializer(employees.GetType(), 
                new DataContractJsonSerializerSettings
                {
                    DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ssZ")
                }
            );
            serializer.WriteObject(stream, employees);
        }
    }

    [XmlRoot("novelist")]
    public class Novelist
    {
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "birth")]
        public DateTime Birth { get; set; }
        [XmlArray("masterpieces")]
        [XmlArrayItem("title", typeof(string))]
        public string[] Masterpieces { get; set; }
        public static void NovelistDesirialize()
        {
            using var reader = XmlReader.Create("novelist.xml");
            var serializer = new XmlSerializer(typeof(Novelist));
            var novelist = serializer.Deserialize(reader) as Novelist;
            Console.WriteLine(novelist.Name);
        }
    }
    class Program
    {
        static void Main()
        {
            Novelist.NovelistDesirialize();
        }
    }
}
