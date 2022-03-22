using System;
using System.Collections.Generic;
using System.Linq;

namespace _73.Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            
            var inputNumber = int.Parse(input);
            var num = input.ToCharArray();

            var digits = new List<int>();

            for (int i = 0; i < num.Length; i++)
            {
                var digit = int.Parse(num[i].ToString());
                digits.Add(digit);
            }

            var rows = digits[0] + digits[1];
            var cols = digits[0] + digits[2];
            

            for (int row = 0; row < rows ; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (inputNumber % 5 == 0)
                    {
                        inputNumber -= digits[0];
                        Console.Write(inputNumber + " ");
                    }
                    else if (inputNumber % 3 == 0)
                    {
                        inputNumber -= digits[1];
                        Console.Write(inputNumber + " ");
                    }
                    else
                    {
                        inputNumber += digits[2];
                        Console.Write(inputNumber + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
