namespace GameOfNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int final = int.Parse(Console.ReadLine());
            int magicSum = int.Parse(Console.ReadLine());

            int magicFirst = int.MinValue;
            int magicSecond = int.MinValue;
            bool isFindSum = false;
            int combinations = 0;

            for (int firstNum = start; firstNum <= final; firstNum++)
            {
                for (int secondNum = start; secondNum <= final; secondNum++)
                {
                    if (firstNum + secondNum == magicSum)
                    {
                        magicFirst = firstNum;
                        magicSecond = secondNum;
                        isFindSum = true;
                    }
                    combinations++;
                }
            }

            if (isFindSum)
            {
                Console.WriteLine($"Number found! {magicFirst} + {magicSecond} = {magicSum}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicSum}");
            }
        }
    }
}
