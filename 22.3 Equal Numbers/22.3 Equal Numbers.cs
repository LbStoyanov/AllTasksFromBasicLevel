using System;

namespace _22._3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = decimal.Parse(Console.ReadLine());
            var number2 = decimal.Parse(Console.ReadLine());
            var number3 = decimal.Parse(Console.ReadLine());
            if (number1 == number2 && number1 == number3)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
