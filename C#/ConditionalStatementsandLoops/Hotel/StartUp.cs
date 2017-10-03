namespace Hotel
{
    using System;

    public class StartUp
    {
        private static double studioPrice;
        private static double doublePrice;
        private static double suitePrice;

        public static void Main()
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            if (month == "May" || month == "October")
            {
                if (nights > 7)
                {
                    studioPrice = 50 * 0.95;
                }
                else
                {
                    studioPrice = 50;
                }
                doublePrice = 65;
                suitePrice = 75;
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60;
                if (nights > 14)
                {
                    doublePrice = 72 * 0.9;
                }
                else
                {
                    doublePrice = 72;
                }
                suitePrice = 82;
            }
            else
            {
                studioPrice = 68;
                doublePrice = 77;
                if (nights > 14)
                {
                    suitePrice = 89 * 0.85;
                }
                else
                {
                    suitePrice = 89;
                }
            }

            if (month == "September" || month == "October")
            {
                if (nights > 7)
                {
                    Console.WriteLine($"Studio: {((nights - 1) * studioPrice):F2} lv.");
                }
                else
                {
                    Console.WriteLine($"Studio: {(nights * studioPrice):F2} lv.");
                }
            }
            else
            {
                Console.WriteLine($"Studio: {(nights * studioPrice):F2} lv.");
            }


            Console.WriteLine($"Double: {(nights * doublePrice):F2} lv.");
            Console.WriteLine($"Suite: {(nights * suitePrice):F2} lv.");
        }
    }
}
