namespace TriangleOfNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());

            string result = "";
            for (int i = 1; i <= lines; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += $"{i} ";
                }
                Console.WriteLine(result);
                result = "";
            }
        }
    }
}
