namespace CakeIngredients
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            int count = 0;
            
            while (input != "Bake!")
            {
                count++;

                Console.WriteLine($"Adding ingredient {input}.");

                input = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
