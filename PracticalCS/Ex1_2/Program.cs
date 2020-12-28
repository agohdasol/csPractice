using System;

namespace Ex1_2
{
    class MyClass
    {
        public int X { get; set; }
        public int Y { get; set; }
        public MyClass(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    struct MyStruct
    {
        public int X { get; set; }
        public int Y { get; set; }
        public MyStruct(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    class Program
    {
        public static void PrintObjects(MyClass myClass, MyStruct myStruct)
        {
            Console.WriteLine("MyClass : {0}, {1}", myClass.X, myClass.Y);
            Console.WriteLine("MyStruct : {0}, {1}", myStruct.X, myStruct.Y);

            myClass.X *= 2;
            myClass.Y *= 2;
            myStruct.X *= 2;
            myStruct.Y *= 2;
        }
        static void Main()
        {
            MyClass myClass = new MyClass(10, 15);
            MyStruct myStruct = new MyStruct(20, 25);
            PrintObjects(myClass, myStruct);

            Console.WriteLine("----------");
            Console.WriteLine("myClass : {0}, {1}", myClass.X, myClass.Y);
            Console.WriteLine("myStruct : {0}, {1}", myStruct.X, myStruct.Y);
        }
    }
}
