using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry;
            int score = 0;
            int newScore;
            int average;
            int testCount = 0;

            WriteLine("To close calculator, type 1001");
            do
            {
                WriteLine("Please enter a test score");
                entry = ReadLine();
                newScore = Convert.ToInt32(entry);

                if (newScore >= 0 && newScore <= 100)
                {
                    testCount = testCount + 1;
                    score = score + newScore;
                    average = score / testCount;
                    WriteLine("You took " + testCount + " tests and your average score was " + average);
                }
                else
                {
                    WriteLine("Error");
                }
            }
            while (entry != "1001");
        }
    }
}
