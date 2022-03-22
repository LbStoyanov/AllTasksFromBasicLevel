using System;

namespace _24.Pipes_In_Pool
{
    class Program
    {
        static void Main()
        {
            var poolCapacityInLiters = decimal.Parse(Console.ReadLine());              
            var flowRateOfThefirstTube = decimal.Parse(Console.ReadLine());            
            var flowRateOfTheSecondTube = decimal.Parse(Console.ReadLine());            
            var breakOfTheWorker = decimal.Parse(Console.ReadLine());                   
            var firstPipeLiters = flowRateOfThefirstTube * breakOfTheWorker;
            var secondPipeLiters = flowRateOfTheSecondTube * breakOfTheWorker;
            
            var quantityPourInThePool = (flowRateOfThefirstTube + flowRateOfTheSecondTube) * breakOfTheWorker;


            if (poolCapacityInLiters >= quantityPourInThePool)
            {
                var difference = Math.Floor(quantityPourInThePool / poolCapacityInLiters * 100);
                var pipe1 = Math.Floor(firstPipeLiters / quantityPourInThePool * 100);
                var pipe2 = Math.Floor(secondPipeLiters / quantityPourInThePool * 100);

                Console.WriteLine($"The pool is {difference}% full. Pipe 1: {pipe1}%. Pipe 2: {pipe2}%.");
            }
            else
            {
                var litersOver = quantityPourInThePool - poolCapacityInLiters;
                Console.WriteLine($"For {breakOfTheWorker} hours the pool overflows with {litersOver} liters.");
            }
        }
    }
}
