using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            string initial;
            double saleInput;
            double daniTotal = 0;
            double edwardTotal = 0;
            double francisTotal = 0;
            double grandTotal = 0;

            WriteLine("Please enter a salesperson's initial");
            initial = (ReadLine());

            while (initial != "z" && initial != "Z") 
            {
                if (initial == "d" || initial == "D")
                {
                    WriteLine("Please enter the sale amount");
                    saleInput = Convert.ToDouble(ReadLine());
                    daniTotal = daniTotal + saleInput;
                    WriteLine("Please enter a salesperson's initial");
                    initial = (ReadLine());
                }

                else if (initial == "e" || initial == "E")
                {
                    WriteLine("Please enter the sale amount");
                    saleInput = Convert.ToDouble(ReadLine());
                    edwardTotal = edwardTotal + saleInput;
                    WriteLine("Please enter a salesperson's initial");
                    initial = (ReadLine());
                }

                else if (initial == "f" || initial == "F")
                {
                    WriteLine("Please enter the sale amount");
                    saleInput = Convert.ToDouble(ReadLine());
                    francisTotal = francisTotal + saleInput;
                    WriteLine("Please enter a salesperson's initial");
                    initial = (ReadLine());
                }

                else
                {
                    WriteLine("Invalid initial");
                    WriteLine("Please enter a salesperson's initial");
                    initial = (ReadLine());
                }

            } 

            WriteLine("Danielle's total sales were {0}", daniTotal.ToString("C"));
            WriteLine("Edward's's total sales were {0}", edwardTotal.ToString("C"));
            WriteLine("Francis' total sales were {0}", francisTotal.ToString("C"));
            grandTotal =  (daniTotal + edwardTotal + francisTotal);
            WriteLine("The grand total was {0}", grandTotal.ToString("C"));

            if (daniTotal > edwardTotal && daniTotal > francisTotal)
            {
                WriteLine("Danielle was the employee of the month with {0} in sales", daniTotal.ToString("C"));
            }
            else if (edwardTotal > daniTotal && edwardTotal > francisTotal)
            {
                WriteLine("Edward was the employee of the month with {0} in sales", edwardTotal.ToString("C"));
            }
            else if (francisTotal > daniTotal && francisTotal > edwardTotal)
            {
                WriteLine("Francis was the employee of the month with {0} in sales", daniTotal.ToString("C"));
            }
        }
    }
}
