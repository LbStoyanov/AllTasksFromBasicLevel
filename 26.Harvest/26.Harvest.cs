using System;

namespace _26.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var vineYardArea = decimal.Parse(Console.ReadLine());
            var grapesPerSquareMeter = decimal.Parse(Console.ReadLine());

            var litersOfWineNeeded = decimal.Parse(Console.ReadLine());
            var workersCount = decimal.Parse(Console.ReadLine());

            var totalHarvest = vineYardArea * grapesPerSquareMeter;
            var harvestForProducing = (totalHarvest / 100) * 40;
            var totalWineProducedInLiters = harvestForProducing / 2.5m;
            if (totalWineProducedInLiters < litersOfWineNeeded)
            {
                var missingWine = litersOfWineNeeded - totalWineProducedInLiters;
                Console.WriteLine($"It will be a tough winter! More {(Math.Floor(missingWine))} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(totalWineProducedInLiters)} liters.");
                var difference = totalWineProducedInLiters - litersOfWineNeeded;
                var winePerWorker = difference / workersCount;
                Console.WriteLine($"{Math.Ceiling(difference)} liters left -> {Math.Ceiling(winePerWorker)} liters per person.");

            }
            
        }
    }
}
