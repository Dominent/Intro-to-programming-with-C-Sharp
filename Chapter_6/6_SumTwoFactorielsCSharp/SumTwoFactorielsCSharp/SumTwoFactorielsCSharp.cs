using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTwoFactorielsCSharp
{
    class SumTwoFactorielsCSharp
    {
        static void Main(string[] args)
        {
            int valN;
            int valK;
            int factorielN = 1;
            int factorielK = 1;
            int sumVal;

            Console.WriteLine("Enter N!: ");
            valN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter K!: ");
            valK = Convert.ToInt32(Console.ReadLine());

            
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
            sumVal = factorielK/ factorielN;
          
            
            Console.WriteLine("{0}",sumVal);  


        }
    }
}
