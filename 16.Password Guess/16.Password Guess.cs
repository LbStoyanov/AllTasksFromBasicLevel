using System;

namespace _16.Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string correctPass = "s3cr3t!P@ssw0rd";
            if (password == correctPass)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
