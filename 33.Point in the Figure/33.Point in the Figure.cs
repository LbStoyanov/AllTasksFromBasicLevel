using System;
namespace _13.Point_in_the_Figure
{
    class Program
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if ((x >= 0 && x <= h * 3 && y == 0)
                || (y >= 0 && y <= h && x == 0)
                || (y == h && x >= 0 && x <= h)
                || (x == h && y >= h && y <= h * 4)
                || (y == h * 4 && x >= h && x <= h * 2)
                || (x == h * 2 && y >= h && y <= h * 4)
                || (y == h && x >= h * 2 && x <= h * 3)
                || (x == h * 3 && y >= 0 && y <= h))
            {
                Console.WriteLine("border");
            }
            else if (x < 0 || y < 0
                || x > h * 3 || y > h * 4
                || (x < h && y > h && y <= h * 4)
                || (x > h * 2 && y > h && y <= h * 4))
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("inside");
            }
        }
    }
}