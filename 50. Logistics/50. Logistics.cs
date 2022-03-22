using System;

namespace _50._Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var countOfCargos = int.Parse(Console.ReadLine());
            
            var totalTonnage = 0.0;

            var microbusTonnage = 0.0;
            var truckTonnage = 0.0;
            var trainTonnage = 0.0;

            for (int cargocounter = 0; cargocounter < countOfCargos; cargocounter++)
            {
                var tonnageOfCurrentCargo = double.Parse(Console.ReadLine());
                totalTonnage += tonnageOfCurrentCargo;
                if (tonnageOfCurrentCargo <= 3)
                {
                    microbusTonnage += tonnageOfCurrentCargo;
                }
                else if(tonnageOfCurrentCargo <= 11) 
                {
                    truckTonnage += tonnageOfCurrentCargo;
                }
                else
                {
                    trainTonnage += tonnageOfCurrentCargo;
                }
            }

            var microbusPercentage = (microbusTonnage / totalTonnage) * 100;
            var truckPercentage = (truckTonnage / totalTonnage) * 100;
            var trainPercentage = (trainTonnage / totalTonnage) * 100;
            var middlePriceOfTonage = (microbusTonnage * 200 + truckTonnage * 175 + trainTonnage * 120) / totalTonnage;

            Console.WriteLine($"{middlePriceOfTonage:f2}");
            Console.WriteLine($"{microbusPercentage:f2}%");
            Console.WriteLine($"{truckPercentage:f2}%");
            Console.WriteLine($"{trainPercentage:f2}%");

        }
    }
}
