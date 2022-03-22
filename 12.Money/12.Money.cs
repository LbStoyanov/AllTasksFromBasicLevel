using System;

namespace _12.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal BGN = 1168;
            var bitcoinQuantity = decimal.Parse(Console.ReadLine());
            var bitcoinsInLeva = bitcoinQuantity * BGN;

            var chineseIuan = decimal.Parse(Console.ReadLine());
            var chineseIuanInUsd = chineseIuan * 0.15m;
            var chineseIuanInLeva = chineseIuanInUsd * 1.76m;

            var totalAmountInLeva = bitcoinsInLeva + chineseIuanInLeva;
            var totalAmountInEuro = totalAmountInLeva / 1.95m;

            var comision = decimal.Parse(Console.ReadLine()) / 100;
            

            var totalSum = totalAmountInEuro - (totalAmountInEuro * comision);

            Console.WriteLine(totalSum);
        }
    }
}
