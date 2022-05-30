using System;

namespace _02._Bracelet_Stand
{
    class Program
    {
        static void Main(string[] args)
        {
            double pocketMoneyPerDay = double.Parse(Console.ReadLine());
            double moneyEarnedFromSells = double.Parse(Console.ReadLine());
            double expensesForWholePeriod = double.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double savedPocketMoney = pocketMoneyPerDay * 5;
            double savedMoneyfromSels = moneyEarnedFromSells * 5;

            double totalMoneysaved = savedMoneyfromSels + savedPocketMoney;
            double finalAmountleft = totalMoneysaved - expensesForWholePeriod;

            
            

            if (finalAmountleft > presentPrice)
            {
                //var moneyNeeded = Math.Abs(moneyLeft - presentPrice);
                Console.WriteLine($"Profit: {finalAmountleft:f2} BGN, the gift has been purchased.");
            }
            else
            {
                var difference = presentPrice - finalAmountleft;
                Console.WriteLine($"Insufficient money: {difference:f2} BGN.");
            }


        }
    }
}
