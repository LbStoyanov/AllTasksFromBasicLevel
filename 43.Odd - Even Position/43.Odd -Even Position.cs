using System;
using System.Collections.Generic;
using System.Linq;

namespace _43.Odd___Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                Console.WriteLine($"OddSum=0");
                Console.WriteLine($"OddMin=No");
                Console.WriteLine($"OddMax=No");
                Console.WriteLine($"EvenSum=0");
                Console.WriteLine($"EvenMin=No");
                Console.WriteLine($"EvenMax=No");
                return;
            }
            var oddSumList = new List<double>();

            var evenSumList = new List<double>();


            for (int i = 1; i <= num; i++)
            {
                var currentNum = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSumList.Add(currentNum);

                }
                else
                {
                    oddSumList.Add(currentNum);

                }

            }

            oddSumList.Sort();
            evenSumList.Sort();
            var oddSum = oddSumList.Sum();
            
            var oddMin = oddSumList.Min();

            var evenSum = evenSumList.Sum();
            
            


            if (oddSumList.Count < 1)
            {
                Console.WriteLine($"OddSum=0");
                Console.WriteLine($"OddMin=No");
                Console.WriteLine($"OddMax=No");
                if (evenSumList.Count < 1)
                {
                    Console.WriteLine($"EvenSum=0");
                    Console.WriteLine($"EvenMin=No");
                    Console.WriteLine($"EvenMax=No");
                    return;
                }
                else
                {
                    var evenMax = evenSumList.Max();
                    var evenMin = evenSumList.Min();
                    Console.WriteLine($"EvenSum={evenSum}");
                    Console.WriteLine($"EvenMin={evenMin}");
                    Console.WriteLine($"EvenMax={evenMax}");
                    return;
                }
            }
            else
            {
                var oddMax = oddSumList.Max();
                Console.WriteLine($"OddSum={oddSum}");
                Console.WriteLine($"OddMin={oddMin}");
                Console.WriteLine($"OddMax={oddMax}");
                if (evenSumList.Count < 1)
                {
                    Console.WriteLine($"EvenSum=0");
                    Console.WriteLine($"EvenMin=No");
                    Console.WriteLine($"EvenMax=No");
                    return;
                }
                else
                {
                    var evenMax = evenSumList.Max();
                    var evenMin = evenSumList.Min();
                    Console.WriteLine($"EvenSum={evenSum}");
                    Console.WriteLine($"EvenMin={evenMin}");
                    Console.WriteLine($"EvenMax={evenMax}");
                }

            }

        }
    }
}
