using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorielAgainCSharp
{
    class FactorielAgainCSharp
    {
        static void Main(string[] args)
        {
            int valN;
            int valK;
            int factorielN = 1;
            int factorielK = 1;
            long sumVal;
            int valNK = 0;
            long factorielNK = 1;

            Console.WriteLine("Enter N!: ");
            valN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter K!: ");
            valK = Convert.ToInt32(Console.ReadLine());

            valNK = valK - valN;

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
            while (true)
            {
                if (valK <= 1)
                {
                    break;
                }
                else
                {
                    factorielK *= valK;
                    --valK;
                }

            }
            while (true)
            {
                if (valNK <= 1)
                {
                    break;
                }
                else
                {
                    factorielNK *= valNK;
                    --valNK;
                }

            }
            
            sumVal = (factorielK * factorielN) / factorielNK;


            Console.WriteLine("{0}", sumVal);  
        }
    }
}
