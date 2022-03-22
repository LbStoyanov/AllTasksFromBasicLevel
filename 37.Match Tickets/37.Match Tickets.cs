using System;

namespace _37.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = decimal.Parse(Console.ReadLine());
            var category = Console.ReadLine();
            var groupCount = int.Parse(Console.ReadLine());

            
            var trasportCost = 0.0m;
            
            if (groupCount <= 4)
            {
                trasportCost = budget * 0.75m;
            }
            else if (groupCount <= 9)
            {
                trasportCost = budget * 0.60m;
            }
            else if (groupCount <= 24)
            {
                trasportCost = budget * 0.50m;
            }
            else if (groupCount <= 49)
            {
                trasportCost = budget * 0.40m;
            }
            else
            {
                trasportCost = budget * 0.25m;
            }

            var ticketCost = 0.0m;
            if (category == "VIP")
            {
                ticketCost = groupCount * 499.99m;
            }
            else if (category == "Normal")
            {
                ticketCost = groupCount * 249.99m;
            }
            var totalCost = trasportCost + ticketCost;

            if (budget >= totalCost)
            {
                var difference = budget - totalCost;
                Console.WriteLine($"Yes! You have {difference:f2} leva left.");
            }
            else
            {
                var moneyNeeded = totalCost - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeeded:f2} leva.");
            }
        }
    }
}
