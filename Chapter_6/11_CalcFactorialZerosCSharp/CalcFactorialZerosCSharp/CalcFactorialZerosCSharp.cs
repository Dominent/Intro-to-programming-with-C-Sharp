using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcFactorialZerosCSharp
{
    class CalcFactorialZerosCSharp
    {
        static int FactorialN(int valN) // Calculates Factoriel of a given number. 
        {
            int factorialN = 1;
            while (true)
            {
                if (valN <= 1)
                {
                    break;
                }
                else
                {
                    factorialN *= valN;
                    --valN;
                }
            }
            return factorialN;
        }

        static void Main(string[] args)
        {
            int valN = 0;
            int sumOfN = 0;

            Console.WriteLine("Enter N: ");
            valN = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= valN; ++i )
            {
                sumOfN += (valN / (int)Math.Pow(5, i));
                
            }
            
            Console.WriteLine("{0}", FactorialN(valN));
            Console.WriteLine("{0}",sumOfN);
        }
    }
}
