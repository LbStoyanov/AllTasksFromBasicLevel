using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            double ageOfLily = double.Parse(Console.ReadLine());
            double londeryPrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double amountOfMoney = 10;
            double moneySaved = 0;
            double numberOfToys = 0;                        
            double moneyTaken = 0;
            double allMoney = 0;
            for (int i = 1; i <= ageOfLily; i++)
            {

                if (i % 2 == 0 /*&& i != 1*/)
                {
                    moneySaved = moneySaved + amountOfMoney;
                    amountOfMoney += 10;
                    moneyTaken++;
                }
                else /*if (i % 2 != 0)*/
                {
                    numberOfToys++;
                }
            }
            allMoney = (numberOfToys * toyPrice) + (moneySaved - moneyTaken);
            if (allMoney >= londeryPrice)
            {
                allMoney = allMoney - londeryPrice;
                Console.WriteLine($"Yes! {allMoney:f2}");
            }
            else
            {
                allMoney = Math.Abs(allMoney - londeryPrice);
                Console.WriteLine($"No! {allMoney:f2}");
            }
            
        }
    }
}
