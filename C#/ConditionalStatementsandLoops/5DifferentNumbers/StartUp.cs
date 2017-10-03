namespace _5DifferentNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int final = int.Parse(Console.ReadLine());

            var difference = final - start;

            if (difference < 5)
            {
                Console.WriteLine("No");
            }

            for (int firstNum = start; firstNum <= final; firstNum++)
            {
                for (int secondNum = firstNum + 1; secondNum <= final; secondNum++)
                {
                    for (int thirdNum = secondNum + 1; thirdNum <= final; thirdNum++)
                    {
                        for (int forthNum = thirdNum + 1; forthNum <= final; forthNum++)
                        {
                            for (int fifthNum = forthNum + 1; fifthNum <= final; fifthNum++)
                            {
                                Console.WriteLine($"{firstNum} {secondNum} {thirdNum} {forthNum} {fifthNum}");
                            }
                        }
                    }
                }
            }
        }
    }
}
