using System;

namespace Ex4
{
    class YearMonth
    {
        public int Year { get; private set; }
        public int Month { get; private set; }
        public bool Is21Century
        {
            get
            {
                if (this.Year >= 2001 && this.Year <= 2100)
                    return true;
                else
                    return false;
            }
        }
        public YearMonth(int year, int month)
        {
            this.Year = year;
            this.Month = month; //12이상이 입력된 경우 구현 생략
        }
        public YearMonth AddOneMonth()
        {
            int year = this.Year;
            int month = this.Month + 1;
            if (month >= 13)
            {
                month = 1;
                year++;
            }
            return new YearMonth(year, month);
        }
        public override string ToString()
        {
            return String.Format($"{this.Year}년 {this.Month}월");
        }
    }
    class Program
    {
        //4.2 - 3
        public static YearMonth Get21Century(YearMonth[] yearMonths)
        {
            foreach (var item in yearMonths)
            {
                if (item.Is21Century)
                    return item;
            }
            return null;
        }
        static void Main()
        {
            //4.2 - 1
            YearMonth[] yearMonths = new YearMonth[5]
            {
                new YearMonth(1999,1),
                new YearMonth(2004,12),
                new YearMonth(2021,5),
                new YearMonth(2035,6),
                new YearMonth(2012,12),
            };
            //4.2 - 2
            foreach (var item in yearMonths)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("------");
            //4.2 - 3
            //YearMonth yearMonth21 = yearMonths.FirstOrDefault(yearMonth => yearMonth.Is21Century);

            //4.2 - 4
            if (Get21Century(yearMonths) != null)
                Console.WriteLine(Get21Century(yearMonths).ToString());
            else
                Console.WriteLine("21세기 데이터는 없습니다.");
            Console.WriteLine("------");
            //4.2 - 5
            YearMonth[] newYearMonths = new YearMonth[yearMonths.Length];
            for (int i = 0; i < yearMonths.Length; i++)
            {
                newYearMonths[i] = yearMonths[i].AddOneMonth();
            }
            foreach (var item in newYearMonths)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("------");
        }
    }
}
