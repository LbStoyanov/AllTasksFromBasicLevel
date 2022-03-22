using System;

namespace _46.Smart_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageOfLily = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double priceForToy = double.Parse(Console.ReadLine());

            var toyCounter = 0;
            
            var moneyTakenFromTheBrother = 0.0;
            var moneyForBirthday = 10;
            var savedMoney = 0.0;

            for (int i = 1; i <= ageOfLily; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += moneyForBirthday;
                    moneyForBirthday += 10;
                    moneyTakenFromTheBrother++;
                }
                else
                {
                    toyCounter++;
                }
            }
            var totalMoneyFromToySell = toyCounter * priceForToy;
            var totalMoneySaved = savedMoney - moneyTakenFromTheBrother;
            var totalAmountSaved = totalMoneyFromToySell + totalMoneySaved;

            if (totalAmountSaved >= washingMachinePrice)
            {
                var moneyLeft = totalAmountSaved - washingMachinePrice;
                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else
            {
                var moneyNeeded = washingMachinePrice - totalAmountSaved;
                Console.WriteLine($"No! {moneyNeeded:f2}");
            }

        }
    }
}
