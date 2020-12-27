using System;

namespace Ch2
{
    class Program
    {
        static double FeetToMeter(int feet)
        {
            return feet * 0.3048;
        }
        static void Main(string[] args)
        {
            for (int feet = 1; feet < 11; feet++)
            {
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, FeetToMeter(feet));
            }
                
        }
    }
}
