using System;

namespace _54.Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int rows = 1; rows <= n; rows++)
            {
                Console.Write('$');
                for (int columns = 1; columns < rows; columns++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }
        }
    }
}
