using System;

namespace Ex1_3
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - Birthday.Year;
            if (today < Birthday.AddYears(age))
                age--;
            return age;
        }
    }
    public class Student : Person
    {
        public int Grade { get; set; }
        public int ClassNumber { get; set; }
    }
    class Program
    {
        public static void TestMethodObject(object obj)
        {
            Console.WriteLine("오브젝트 인풋");
        }
        public static void TestMethodPerson(Person obj)
        {
            Console.WriteLine("Person 인풋");
        }
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Name = "홍길동",
                Birthday = new DateTime(2000, 01, 03, 13, 32, 30),
                Grade = 1,
                ClassNumber = 3,
            };

            Console.WriteLine($"{student.Name}, {student.Birthday}, {student.Grade}, {student.ClassNumber}");

            TestMethodObject(student);
            TestMethodPerson(student);
        }
    }
}
