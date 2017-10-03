using System;
using System.Runtime.InteropServices;
using System.Xml.Schema;

namespace ChooseDrink
{
    public class StartUp
    {
        public static void Main()
        {
            var profession = Console.ReadLine();
            var quantities = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            switch (profession)
            {
                case "Athlete":
                    totalPrice = quantities * 0.7;
                    break;
                case "Businessman":
                case "Businesswoman":
                    totalPrice = quantities * 1.0;
                    break;
                case "SoftUni Student":
                    totalPrice = quantities * 1.7;
                    break;
                default:
                    totalPrice = quantities * 1.2;
                    break;
            }

            Console.WriteLine($"The {profession} has to pay {totalPrice:N}.");
        }
    }
}
