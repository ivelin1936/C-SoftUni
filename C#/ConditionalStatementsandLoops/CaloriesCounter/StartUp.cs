namespace CaloriesCounter
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            int calories = 0;

            for (int i = 0; i < count; i++)
            {
                string ingredient = Console.ReadLine();
                if (ingredient.ToLower() == "pepper")
                {
                    calories += 50;
                }
                else if (ingredient.ToLower() == "salami")
                {
                    calories += 600;
                }
                else if (ingredient.ToLower() == "tomato sauce")
                {
                    calories += 150;
                }
                else if (ingredient.ToLower() == "cheese")
                {
                    calories += 500;
                }
            }

            Console.WriteLine($"Total calories: {calories}");
        }
    }
}
