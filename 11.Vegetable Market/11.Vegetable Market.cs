using System;

namespace _11.Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegetablesPrice = decimal.Parse(Console.ReadLine());
            var fruitsPrice = decimal.Parse(Console.ReadLine());
            var totalQuantityOfVegetables = decimal.Parse(Console.ReadLine());
            var totalQuantityOfFruits = decimal.Parse(Console.ReadLine());
            var vegetableTotalPrice = vegetablesPrice * totalQuantityOfVegetables;
            var fruitTotalPrice = fruitsPrice * totalQuantityOfFruits;
            var totalSum = (vegetableTotalPrice + fruitTotalPrice) / 1.94m;
            Console.WriteLine(totalSum);
        }
    }
}
