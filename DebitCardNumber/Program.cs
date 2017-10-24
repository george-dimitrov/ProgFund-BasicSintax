using System;

namespace DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int forth = int.Parse(Console.ReadLine());

            Console.WriteLine($"{FormatToFourSigns(first)} {FormatToFourSigns(second)} {FormatToFourSigns(third)} {FormatToFourSigns(forth)}");
        }

        private static string FormatToFourSigns(int number)
        {
            string numToStr = number.ToString();
            if (numToStr.Length == 1)
            {
                return "000" + numToStr;
            }
            else if (numToStr.Length == 2)
            {
                return "00" + numToStr;
            }
            else if (numToStr.Length == 3)
            {
                return "0" + numToStr;
            }
            else if (numToStr.Length == 4)
            {
                return numToStr;
            }
            else
            {
                return "****";
            }
        }
    }
}
