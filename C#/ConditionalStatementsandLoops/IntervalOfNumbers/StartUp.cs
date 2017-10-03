namespace IntervalOfNumbers
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            int start = Math.Min(first, second);
            int end = Math.Max(first, second);

            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
