
using System;

namespace _36.Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var operationSign =Console.ReadLine();
            var result = 0.0;
            if (operationSign == "+")
            {
                result = num1 + num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} + {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} + {num2} = {result} - odd");
                }
            }
            else if (operationSign == "-")
            {
                result = num1 - num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} - {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} - {num2} = {result} - odd");
                }
            }
            else if(operationSign == "*")
            {
                result = num1 * num2;
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{num1} * {num2} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} * {num2} = {result} - odd");
                }
            }
            else if (operationSign == "/")
            {
                
                if ( num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result:f2}");
                }
                
            }
            else if (operationSign == "%")
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    result = num1 % num2;
                    Console.WriteLine($"{num1} % {num2} = {result}");
                }
                
            }

        }
    }
}
