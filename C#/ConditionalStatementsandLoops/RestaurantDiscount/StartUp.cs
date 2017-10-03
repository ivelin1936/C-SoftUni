namespace RestaurantDiscount
{
    using System;

    public class StartUp
    {
        private static int people;
        private static int discount;
        private static int packagePrice;
        
        private static double bestPrize;
        private static string hall;

        public static void Main()
        {
            people = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();

            if (package == "Normal")
            {
                discount = 5;
                packagePrice = 500;
            }
            else if (package == "Gold")
            {
                discount = 10;
                packagePrice = 750;
            }
            else
            {
                discount = 15;
                packagePrice = 1000;
            }
            
            if (people < 50)
            {
                CheckPrice(2500, "Small Hall");
            }
            else if (50 <= people && people <= 100)
            {
                CheckPrice(5000, "Terrace");
            }
            else if (100 <= people && people <= 120)
            {
                CheckPrice(7500, "Great Hall");
            }

            if (bestPrize > 0)
            {
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {bestPrize:N2}$");

            }
            else
            {
                Console.WriteLine($"We do not have an appropriate hall.");
            }
        }

        private static void CheckPrice(int roomPrice, string currentHall)
        {
            double prize = (roomPrice + packagePrice);
            double currentDiscount = prize * discount / 100;
            double prizePerPerson = (prize - currentDiscount) / people;

            if (prizePerPerson > bestPrize)
            {
                bestPrize = prizePerPerson;
                hall = currentHall;
            }
        }
    }
}
