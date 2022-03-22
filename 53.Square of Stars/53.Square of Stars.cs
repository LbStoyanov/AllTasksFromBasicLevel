using System;

namespace _53.Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                Console.Write('*');
                for (int columns = 1; columns < n; columns++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}
