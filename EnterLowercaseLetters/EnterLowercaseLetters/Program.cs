using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EnterLowercaseLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            char letter;
            do
            {
                WriteLine("Please enter a lowercase letter");
                input = ReadLine();
                letter = Convert.ToChar(input);
                if (letter >= 'a' && letter <= 'z')
                {
                    WriteLine("OK");
                }
                else
                {
                    WriteLine("Error");
                }

            }
            while (input != "!");
        }
    }
}
