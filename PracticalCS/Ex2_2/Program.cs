using System;

namespace Ex2_2
{
    public static class InchConverter
    {
        private const double ratio = 0.0254;
        public static double ToMeter(int inch)
        {
            return inch * ratio;
        }
        public static double FromMeter(int meter)
        {
            return meter / ratio;
        }
    }
    class Program
    {
        static void PrintInchToMeterList(int start, int stop)
        {
            for (int inch = start; inch <= stop; inch++)
            {
                double meter = InchConverter.ToMeter(inch);
                Console.WriteLine("{0} inch = {1:0.0000} m", inch, meter);
            }
        }
        static void PrintMeterToInchList(int start, int stop)
        {
            for (int meter = start; meter <= stop; meter++)
            {
                double inch = InchConverter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000} inch", meter, inch);
            }
        }
        static void Main(string[] args)
        {
            if (args.Length >= 1 && args[0] == "-tom")
            {
                PrintInchToMeterList(1, 10);
            }
            else
            {
                PrintMeterToInchList(1, 10);
            }


        }
    }
}
