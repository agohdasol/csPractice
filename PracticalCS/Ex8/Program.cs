using System;
using System.Globalization;

namespace Ex8
{
    //8.3
    class TimeWatch
    {
        private DateTime time;
        public void Start()
        {
            time = DateTime.Now;
        }
        public TimeSpan Stop()
        {
            if (time != null)
            {
                return DateTime.Now - time;
            }
            return new TimeSpan(0);
        }
    }
    class Program
    {
        public static DateTime NextDay(DateTime date, DayOfWeek dayOfWeek)
        {
            var days = (int)dayOfWeek - (int)(date.DayOfWeek);
            if (days <= 0)
                days += 7;
            return date.AddDays(days);
        }
        //8.2
        public static DateTime NextDay2(DateTime date, DayOfWeek dayOfWeek)
        {
            var nextWeek = date.AddDays(7);
            var days = (int)dayOfWeek - (int)date.DayOfWeek;
            return date.AddDays(days);
        }
        static void Main(string[] args)
        {
            //8.1
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString("yyyy/M/d HH:mm", CultureInfo.InvariantCulture));
            Console.WriteLine(dateTime.ToString("yyyy년MM월dd일 HH시mm분ss초"));
            var culture = new CultureInfo("ko-KR");
            culture.DateTimeFormat.Calendar = new KoreanCalendar();
            Console.WriteLine(dateTime.ToString("ggyyyy년M월d일(ddd요일)", culture));

            TimeWatch tw = new TimeWatch();
            tw.Stop();
        }
    }
}
