namespace DebitCardNumber
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int forthNumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"{firstNumber:D4} {secondNumber:D4} {thirdNumber:D4} {forthNumber:D4}");
        }
    }
}
