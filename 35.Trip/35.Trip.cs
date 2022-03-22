using System;

namespace _35.Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();
            var destination = string.Empty;
            var moneySpended = 0.0;
            var campType = string.Empty;
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    campType = "Camp";
                    moneySpended = budget * 0.30;
                }
                else if(season == "winter")
                {
                    campType = "Hotel";
                    moneySpended = budget * 0.70;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    campType = "Camp";
                    moneySpended = budget * 0.40;
                }
                else if (season == "winter")
                {
                    campType = "Hotel";
                    moneySpended = budget * 0.80;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                campType = "Hotel";
                moneySpended = budget * 0.90;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{campType} - {moneySpended:f2}");
        }
    }
}
