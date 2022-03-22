using System;

namespace _13.Daily_Earnings
{
    class Program
    {
        static void Main(string[] args)
        {
            var workingDaysPerMonth = decimal.Parse(Console.ReadLine());
            var moneyEarnedPerDay = decimal.Parse(Console.ReadLine());
            var usdToLeva = decimal.Parse(Console.ReadLine());
            var monthSalary = workingDaysPerMonth * moneyEarnedPerDay;
            var bonus = monthSalary * 2.5m;
            var yearSalary = (monthSalary * 12) + bonus;
            var taxes = yearSalary * 0.25m;
            var totalAmountInUsd = yearSalary - taxes;
            var totalAmountInLeva = totalAmountInUsd * usdToLeva;
            var averageEarnsInLevaPerDay = totalAmountInLeva / 365;
            Console.WriteLine($"{averageEarnsInLevaPerDay:f2}");
            


        }
    }
}
