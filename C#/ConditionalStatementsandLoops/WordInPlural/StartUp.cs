namespace WordInPlural
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            if (input.EndsWith("y"))
            {
                input = input.Remove(input.Length - 1);
                input += "ies";
            }
            else if (input.EndsWith("o") || input.EndsWith("s") || input.EndsWith("x") || input.EndsWith("z") || input.EndsWith("ch") || input.EndsWith("sh"))
            {
                input += "es";
            }
            else
            {
                input += "s";
            }


            Console.WriteLine(input);
        }
    }
}
