using System;
using System.Globalization;

namespace Ch8
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = new DateTime(1998, 6, 25);
            var culture = new CultureInfo("ko_KR"); 
            culture.DateTimeFormat.Calendar = new KoreanCalendar();
            var dayOfWeek = culture.DateTimeFormat.GetDayName(date.DayOfWeek);
            Console.WriteLine(dayOfWeek);
        }
    }
}
