using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string binaryVal;
            int valN;
            int decimalval = 0;

            Console.WriteLine("Enter Number:");
            binaryVal = Console.ReadLine();
            valN = Convert.ToInt32(binaryVal);
                    
            for(int i  = 0; i < binaryVal.Length; ++i)
            {
                if(valN % 10 == 1)
                {
                    decimalval  = decimalval + (1 * (int) Math.Pow(2, i));  
                }
                valN = valN / 10;
            }

            Console.WriteLine("{0}",decimalval );

        }
    }
}
