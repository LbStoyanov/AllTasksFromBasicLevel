﻿using System;

namespace _17.Number_100To200
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = decimal.Parse(Console.ReadLine());
            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number >= 100 && number <=200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
