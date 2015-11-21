using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialSumOfNXCSharp
{
    class FactorialSumOfNXCSharp
    {
        static int FactorielN(int valN) // Calculates Factoriel of a given number. 
        {
            int factorielN = 1;
            while (true)
            {
                if (valN <= 1)
                {
                    break;
                }
                else
                {
                    factorielN *= valN;
                    --valN;
                }
            }

            return factorielN;
        }
        
        static void Main(string[] args)
        {
            int valN;
            int valX;
            double sumS = 1;

            Console.WriteLine("Enter N!: ");
            valN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter X: ");
            valX = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= valN; ++i )
            {
                sumS = sumS + (FactorielN(i) / (Math.Pow(valX, i)));
            }
                          
                Console.WriteLine("{0}", sumS);
        }
    }
}
