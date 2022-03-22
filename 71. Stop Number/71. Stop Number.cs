using System;

namespace _71._Stop_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var s = int.Parse(Console.ReadLine());

            for (int i = m; i >= n; i--)
            {
                if (i % 2 == 0 && i % 3 == 0 && i == s)
                {
                    return;
                }
                else if(i % 2 == 0 && i % 3 == 0)
                {
                    Console.Write(i + " ");
                }

            }
        }
    }
}
