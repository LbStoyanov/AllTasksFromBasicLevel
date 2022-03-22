using System;

namespace _70.Magic_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            int d1 = 0;
            int d2;
            int d3;
            int d4;
            int d5;
            int d6;

            while (d1 < 10)
            {
                d2 = 0;
                while (d2 < 10)
                {
                    d3 = 0;
                    while (d3 < 10)
                    {
                        d4 = 0;
                        while (d4 < 10)
                        {
                            d5 = 0;
                            while (d5 < 10)
                            {
                                d6 = 0;
                                while (d6 < 10)
                                {
                                    if (d1*d2*d3*d4*d5*d6 == num)
                                    {
                                        Console.Write($"{d1}{d2}{d3}{d4}{d5}{d6} ");
                                    }
                                    d6++;
                                }
                                d5++;
                            }
                            d4++;
                        }
                        d3++;
                    }
                    d2++;
                }
                d1++;
            }
                

         

            
        }
    }
}
