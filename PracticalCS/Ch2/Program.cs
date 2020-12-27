using System;

namespace Ch2
{
    class Program
    {
        static double FeetToMeter(int feet)
        {
            return feet * 0.3048;
        }
        static double MeterToFeet(int meter)
        {
            return meter / 0.3048;
        }
        static void FeetToMeterList(int start, int stop)
        {
            for (int feet = start; feet <= stop; feet++)
            {
                double meter = FeetToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }
        static void MeterToFeetList(int start, int stop)
        {
            for (int meter = start; meter <= stop; meter++)
            {
                double feet = MeterToFeet(meter);
                Console.WriteLine("{0} m = {1:0.0000} ft", meter, feet);
            }
        }
        static void Main(string[] args)
        {
            if(args.Length>=1 && args[0] == "-tom")
            {
                FeetToMeterList(1, 10);
            }
            else
            {
                MeterToFeetList(1, 10);
            }
            
                
        }
    }
}
