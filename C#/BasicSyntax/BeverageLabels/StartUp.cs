using System;

namespace BeverageLabels
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double countEnergy = (energy * volume) / 100;
            double countSugar = (sugar * volume) / 100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{countEnergy}kcal, {countSugar}g sugars");
        }
    }
}
