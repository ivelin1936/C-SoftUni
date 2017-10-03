namespace TestNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int neededSum = int.Parse(Console.ReadLine());

            int currentSum = 0;
            int count = 0;
            for (int firstNum = first; firstNum > 0; firstNum--)
            {
                for (int secondNum = 1; secondNum <= second; secondNum++)
                {
                    currentSum += 3 * firstNum * secondNum;
                    count++;
                    if (currentSum >= neededSum)
                    {
                        break;
                    }
                }
                if (currentSum >= neededSum)
                {
                    break;
                }
            }

            if (currentSum < neededSum)
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {currentSum}");
            }
            else
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {currentSum} >= {neededSum}");
            }
        }
    }
}
