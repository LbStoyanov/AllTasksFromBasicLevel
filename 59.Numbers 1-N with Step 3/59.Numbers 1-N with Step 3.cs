using System;

namespace _59.Numbers_1_N_with_Step_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for (int i = num; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
