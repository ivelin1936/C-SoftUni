namespace MilesToKilometers
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            double kilometers = double.Parse(Console.ReadLine());

            double miles = kilometers * 1.60934;

            Console.WriteLine($"{miles:F2}");
        }
    }
}