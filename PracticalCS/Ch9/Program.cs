using System;
using System.IO;

namespace Ch9
{
    class Program
    {
        public static void ChangeCurrentDirectory()
        {
            var workdir = Directory.GetCurrentDirectory();
            Console.WriteLine(workdir);

            Directory.SetCurrentDirectory(@"D:\csPractice\PracticalCS\Ch9\bin\Debug\netcoreapp3.12");
            var newWorkdir = Directory.GetCurrentDirectory();
            Console.WriteLine(newWorkdir);
        }
        public static void GetDirectoriesInServer()
        {
            //서버 디렉토리 구하기
            var di = new DirectoryInfo(@"\\192.168.123.218\자료실\담당자\황다솔");
            DirectoryInfo[] directories = di.GetDirectories("*", SearchOption.AllDirectories);
            foreach (var dinfo in directories)
            {
                Console.WriteLine(dinfo.FullName);
            }
        }
        static void Main()
        {
            GetDirectoriesInServer();
        }
    }
}
