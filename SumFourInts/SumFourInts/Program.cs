using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace SumFourInts // I kinda coverted #1 into number 2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;
            const int MAX = 4;
            string inputString;
            int exit;

            WriteLine("To exit at any time, please enter 999");
            do
            {
                WriteLine("Enter a number>>>>>>>>");
                inputString = ReadLine();
                num = Convert.ToInt32(inputString);
                sum = num + sum;
                WriteLine("The sum is " + sum);

            }
            while (num != 999);
            {
                ReadLine();
            }
        }
    }
}
