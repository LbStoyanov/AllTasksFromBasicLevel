using System;
using System.Linq;

namespace _23.Number_0_100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] oneToNine = { "zero", "one", "two", "tree", "four", "five", "six", "seven", "eight", "nine" };
            string[] tenToNineteen = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", };
            string[] twentyToHoundred = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            try
            {
                var number = int.Parse(Console.ReadLine());
                if (number < 0 || number > 100) { Console.WriteLine("invalid number"); }
                if (number < 10)
                {
                    Console.WriteLine(oneToNine[number]);

                }
                else if (number > 9 && number < 20)
                {
                    number = number % 10;
                    Console.WriteLine(tenToNineteen[number]);
                }
                else if (number == 100)
                {
                    Console.WriteLine("one hundred");
                }
                else if (number > 19 && number < 100)
                {
                    if (number % 10 == 0)
                    {
                        Console.WriteLine(twentyToHoundred[number / 10]);
                    }
                    else
                    {
                        Console.WriteLine(twentyToHoundred[number / 10] + " " + oneToNine[number % 10]);
                    }
                }
            }
            catch (Exception)
            {
                
                return;
            }
            
        }
    }
}
