using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeBitsCSharp
{
    class ChangeBitsCSharp
    {
        static void Main(string[] args)
        {
            int valN;
            int posP;
            int valV;
            string printValNBinary;
            
            int newVal;

            valN = posP = 0;

            Console.WriteLine("Enter a number: ");
            valN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter position: ");
            posP = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter True for 1 and False for 0: ");
            valV = Convert.ToInt32(Console.ReadLine());

            printValNBinary = Convert.ToString(valN, 2);
            Console.WriteLine(printValNBinary);

          

            if (valV == 0)
            {
                newVal = valN & ~(1 << posP);
                Console.WriteLine(newVal);
            }
            else
            {
                newVal = valN | (1 << posP);
                Console.WriteLine(newVal);
            }
        }
    }
}
