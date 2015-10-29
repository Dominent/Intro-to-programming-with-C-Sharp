using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintBitCSharp
{
    class PrintBitCSharp
    {
        static void Main(string[] args)
        {
            int valN;
            int posP;
            string printValNBinary;
            int mask;
            int i = 1; //0000 0001
                      
            valN = posP = 0;
                       
            Console.WriteLine("Enter a number: ");

            valN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter position: ");

            posP = Convert.ToInt32(Console.ReadLine());

            printValNBinary = Convert.ToString(valN, 2);
            
            Console.WriteLine(printValNBinary);

            mask = i << posP;

            Console.WriteLine((valN & mask) != 0 ? 1 : 0);
            

        }
    }
}
