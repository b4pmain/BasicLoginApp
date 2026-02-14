using System;

namespace BasicLoginApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = "Master";
            string password = "Password123";

            Console.WriteLine("Enter your Username: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Enter your Password");
            string passInput = Console.ReadLine();

            if (userInput == username && passInput == password)
            {
                Console.WriteLine("Login Successful!");
            }
            else
            {
                Console.WriteLine("Invalid Credentials.");
            }
        }
    }
}
