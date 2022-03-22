using System;

namespace _52.Rectangle_of_N_x_N_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                for (int columns = 1; columns <= n; columns++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
