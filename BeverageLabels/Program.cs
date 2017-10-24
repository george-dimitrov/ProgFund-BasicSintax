using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string beverageName = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energiContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            Console.WriteLine($"{volume}ml {beverageName}:");
            Console.WriteLine($"{(double)volume * energiContent / 100}kcal, {(double)volume * sugarContent / 100}g sugars");
        }
    }
}
