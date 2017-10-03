namespace RectangleArea
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var firstNumber = double.Parse(Console.ReadLine());
            var secondNumber = double.Parse(Console.ReadLine());

            var area = firstNumber * secondNumber;

            Console.WriteLine($"{area:F2}");
        }
    }
}