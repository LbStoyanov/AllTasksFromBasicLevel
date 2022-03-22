using System;

namespace _47.Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            var heritage = double.Parse(Console.ReadLine());
            var yearForLiving = int.Parse(Console.ReadLine());
            var years = 18;
            var moneySpended = 0.0;

            for (int i = 1800; i <= yearForLiving; i++)
            {
                if (i % 2 == 0)
                {
                    moneySpended += 12000;
                    years++;
                }
                else
                {
                    moneySpended += 12000 + (50 * years);
                    years++;
                }
            }

            if (heritage >= moneySpended)
            {
                var moneyLeft = heritage - moneySpended;
                Console.WriteLine($"Yes! He will live a carefree life and will have {moneyLeft:f2} dollars left.");
            }
            else
            {
                var moneyNeeded = moneySpended - heritage;
                Console.WriteLine($"He will need {moneyNeeded:f2} dollars to survive.");
            }
        }
    }
}
