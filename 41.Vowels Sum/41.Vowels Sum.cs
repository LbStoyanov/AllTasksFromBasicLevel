using System;

namespace _41.Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var sum = 0.0m;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    sum += 1;
                }
                else if (text[i] == 'e')
                {
                    sum += 2;
                }
                else if (text[i] == 'i')
                {
                    sum += 3;
                }
                else if (text[i] == 'o')
                {
                    sum += 4;
                }
                else if(text[i] == 'u')
                {
                    sum += 5;
                }
            }

            Console.WriteLine($"Vowels = {sum}");
        }
    }
}
