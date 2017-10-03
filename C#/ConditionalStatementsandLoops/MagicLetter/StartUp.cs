namespace MagicLetter
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            string skip = Console.ReadLine();
            string result = "";

            for (char i = startLetter; i <= endLetter; i++)
            {
                for (char j = startLetter; j <= endLetter; j++)
                {
                    for (char k = startLetter; k <= endLetter; k++)
                    {
                        result = $"{i}{j}{k}";
                        if (!result.Contains(skip))
                        {
                            Console.Write(result + " ");
                        }
                    }
                }
            }
        }
    }
}
