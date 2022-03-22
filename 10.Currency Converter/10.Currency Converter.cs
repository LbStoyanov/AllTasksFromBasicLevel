using System;

namespace _10.Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal USD = 1.79549m;
            const decimal EUR = 1.95583m;
            const decimal GBP = 2.53405m;
            //const decimal BGN = 1.00m;
            
            var amount = decimal.Parse(Console.ReadLine());
            string currancyToConvert = Console.ReadLine().ToUpper();
            string currancyIntoConvert = Console.ReadLine().ToUpper();
            var result = 0.0m;

            if (currancyToConvert == "BGN")
            {
                if (currancyIntoConvert == "USD")
                {
                    result = amount / USD;
                }
                else if(currancyIntoConvert == "EUR")
                {
                    result = amount / EUR;
                }
                else if (currancyIntoConvert == "GBP")
                {
                    result = amount / GBP;
                }
            }
            else if (currancyToConvert == "USD")
            {
                if (currancyIntoConvert == "BGN")
                {
                    result = amount * USD;
                }
                else if (currancyIntoConvert == "EUR")
                {
                    result = (amount * USD) / EUR;
                }
                else if (currancyIntoConvert == "GBP")
                {
                    result = (amount * USD) / GBP;
                }
            }
            else if (currancyToConvert == "EUR")
            {
                if (currancyIntoConvert == "BGN")
                {
                    result = amount * EUR;
                }
                else if (currancyIntoConvert == "USD")
                {
                    result = (amount * EUR) / USD;
                }
                else if (currancyIntoConvert == "GBP")
                {
                    result = (amount * EUR) / GBP;
                }
            }
            else if (currancyToConvert == "GBP")
            {
                if (currancyIntoConvert == "BGN")
                {
                    result = amount * GBP;
                }
                else if (currancyIntoConvert == "USD")
                {
                    result = (amount * GBP) / USD;
                }
                else if (currancyIntoConvert == "EUR")
                {
                    result = (amount * GBP) / EUR;
                    
                }
            }
            Console.WriteLine($"{result:f2} {currancyIntoConvert}");
        }
    }
}
