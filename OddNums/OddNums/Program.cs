using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OddNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;

            while (num <= 99)
            {
                Write("{0} ", num);
                num = num + 2;

            }
        }
    }
}
