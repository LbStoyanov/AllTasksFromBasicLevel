using System;

namespace _31.Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();
            decimal rows = decimal.Parse(Console.ReadLine());
            decimal columns = decimal.Parse(Console.ReadLine());
            var price = 0.0m;

            if (ticketType == "Premiere")
            {
                price = 12.00m;
            }
            else if(ticketType == "Normal")
            {
                price = 7.50m;
            }
            else if (ticketType == "Discount")
            {
                price = 5.00m;
            }

            var totalSum = (rows * columns) * price;
            Console.WriteLine($"{totalSum:f2} leva");

        }
    }
}
