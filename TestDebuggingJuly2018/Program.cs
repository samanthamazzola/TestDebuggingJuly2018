using System;
using System.Text.RegularExpressions;

namespace TestDebuggingJuly2018
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid zip code: ");
            string input = Console.ReadLine();

            if (Regex.IsMatch(@"^\d{5}$", input))
            {
                Console.WriteLine("Valid input");
            }
            else
            {
                Console.WriteLine("Input not valid!");
            }       
        }
    }
}
