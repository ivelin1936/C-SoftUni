namespace CountOfIntegers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            int reminder = 0;
            int count = 0;

            while (int.TryParse(input, out reminder))
            {
                count++;
                input = Console.ReadLine();
            }

            Console.WriteLine(count);
        }
    }
}
