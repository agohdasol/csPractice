using System;

namespace Ch2_1
{
    public static class FeetConverter
    {
        private const double ratio = 0.3048;
        public static double ToMeter(int feet)
        {
            return feet * ratio;
        }
        public static double FromMeter(int meter)
        {
            return meter / ratio;
        }
    }
    class Program
    {
        static void PrintFeetToMeterList(int start, int stop)
        {
            for (int feet = start; feet <= stop; feet++)
            {
                double meter = FeetConverter.ToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }
        static void PrintMeterToFeetList(int start, int stop)
        {
            for (int meter = start; meter <= stop; meter++)
            {
                double feet = FeetConverter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
            }
        }
        static void Main(string[] args)
        {
            if(args.Length>=1 && args[0] == "-tom")
            {
                PrintFeetToMeterList(1, 10);
            }
            else
            {
                PrintMeterToFeetList(1, 10);
            }
            
                
        }
    }
}
