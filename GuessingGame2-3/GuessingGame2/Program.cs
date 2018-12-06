using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GuessingGame2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNumber = new Random();
            int random;
            random = ranNumber.Next(1, 11);
            int attempts = 0;
            int guess;
            int pgH = 0;
            int pgHG = 1;
            int pgL = 0;
            int pgLG = 1;

            do
            {
                WriteLine("Please enter a guess between 1 and 10");
                guess = Convert.ToInt32(ReadLine());
                ++attempts;

                if (guess > random && pgH == 0)
                {
                    WriteLine("Your guess was too high");
                    pgH = 1;
                    pgHG = guess;
                }
                else if (guess > random && pgH == 1 && guess > pgHG)
                {
                    WriteLine("You idiot");
                }
                else if (guess > random && guess < pgHG && pgH == 1)
                    WriteLine("Your guess was too high");

                else if (guess < random && pgL == 0)
                {
                    WriteLine("Your guess was too low");
                    pgL = 1;
                    pgLG = guess;
                }
                else if (guess < random && pgL == 1 && guess < pgLG)
                {
                    WriteLine("You idiot");
                }
                else if (guess < random && guess > pgLG && pgL == 1)
                    WriteLine("Your guess was too low");

            } while (guess != random);
            WriteLine("You guessed correctly. It only took you {0} tries.", attempts);
        }
    }
}
