using System;
using System.Text.RegularExpressions;
using static System.Console;

namespace TestDebuggingJuly2018
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            WriteLine("Please enter a valid zip code: ");
            string input = ReadLine();

            if (Regex.IsMatch(@"^\d{5}$", input)) // <-- incorrect format the input should be first and pattern second
            if (Regex.IsMatch(input, @"^\d{5}$")) // stepped over into this //set as breakpoint
                
            {
                WriteLine("Valid input");
            }
            else
            {
                WriteLine("Input not valid!");
            }       
        }
    }
}
