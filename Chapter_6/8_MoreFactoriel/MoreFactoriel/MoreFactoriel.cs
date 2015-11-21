using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Much Amaze
namespace MoreFactoriel
{
    class MoreFactoriel
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
            long catalanVal;

            Console.WriteLine("Enter N!: ");
            valN = Convert.ToInt32(Console.ReadLine());

            catalanVal = FactorielN(2 * valN) / (FactorielN((valN + 1)) * FactorielN(valN));
            Console.WriteLine("{0}", catalanVal);
        }
    }
}
