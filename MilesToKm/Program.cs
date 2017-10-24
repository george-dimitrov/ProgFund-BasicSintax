using System;

namespace MilesToKm
{
    class Program
    {
        private const double oneMileToKm = 1.60934;

        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());

            Console.WriteLine($"{(miles * oneMileToKm):f2}");
        }
    }
}
