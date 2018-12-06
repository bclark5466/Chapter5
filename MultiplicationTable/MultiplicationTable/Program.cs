using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 1, result;

            while (a <= 10)
            {
                result = a * b;
                Write("{0}\t ", result);
                ++b;

                if (b > 10)
                {
                    b = 1;
                    ++a;
                    WriteLine("");
                }
            }
        }
    }
}