using System;

namespace _29.Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string town = Console.ReadLine().ToLower();
            double quantity = double.Parse(Console.ReadLine());
            var price = 0.0;

            if (town == "sofia")
            {
                if (product == "coffee")
                {
                    price = quantity * 0.50;
                }
                else if (product == "water")
                {
                    price = quantity * 0.80;
                }
                else if (product == "beer")
                {
                    price = quantity * 1.20;
                }
                else if (product == "sweets")
                {
                    price = quantity * 1.45;
                }
                else if (product == "peanuts")
                {
                    price = quantity * 1.60;
                }

            }
            else if ( town == "plovdiv")
            {
                if (product == "coffee")
                {
                    price = quantity * 0.40;
                }
                else if (product == "water")
                {
                    price = quantity * 0.70;
                }
                else if (product == "beer")
                {
                    price = quantity * 1.15;
                }
                else if (product == "sweets")
                {
                    price = quantity * 1.30;
                }
                else if (product == "peanuts")
                {
                    price = quantity * 1.50;
                }
            }
            else if (town == "varna")
            {
                if (product == "coffee")
                {
                    price = quantity * 0.45;
                }
                else if (product == "water")
                {
                    price = quantity * 0.70;
                }
                else if (product == "beer")
                {
                    price = quantity * 1.10;
                }
                else if (product == "sweets")
                {
                    price = quantity * 1.35;
                }
                else if (product == "peanuts")
                {
                    price = quantity * 1.55;
                }
            }

            
            Console.WriteLine($"{price:f2}");
        }
    }
}
