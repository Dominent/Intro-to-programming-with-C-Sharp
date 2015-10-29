using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeBitCSharp
{

    class ChangeBitCSharp
    {
        static void Main(string[] args)
        {
            int valN;
            int check_3Bit, check_4Bit, check_5Bit ;
            int i = 1;  //00000001
            int maskBitPos_3, maskBitPos_4, maskBitPos_5;
            int bitPos3 = 4; //00000100
            int bitPos4 = 8; //00001000
            int bitPos5 = 16; //00010000
            string printValNBinary;
                       

            valN = 0;

            Console.WriteLine("Enter a number: ");
            valN = Convert.ToInt32(Console.ReadLine());
            
            printValNBinary = Convert.ToString(valN, 2);
            Console.WriteLine(printValNBinary);

            maskBitPos_3 = i << 3;
            maskBitPos_4 = i << 4;
            maskBitPos_5 = i << 5;

            check_3Bit = ((valN & maskBitPos_3) != 0 ? 1 : 0); //if true 1 else 0
            check_4Bit = ((valN & maskBitPos_3) != 0 ? 1 : 0);
            check_5Bit = ((valN & maskBitPos_3) != 0 ? 1 : 0);


            if (check_3Bit == 0)
            {
                valN = valN & ~(1 << 24);
                Console.WriteLine(valN);
            }
            else
            {
                valN = valN | (1 << 24);
                Console.WriteLine(valN);
            }
            if (check_4Bit == 0)
            {
                valN = valN & ~(1 << 25);
                Console.WriteLine(valN);
            }
            else
            {
                valN = valN | (1 << 25);
                Console.WriteLine(valN);
            }
           
            if (check_5Bit == 0)
            {
                valN = valN & ~(1 << 26);
                Console.WriteLine(valN);
            }
            else
            {
                valN = valN | (1 << 26);
                Console.WriteLine(valN);
            }
        }
    }
}

        }
    }
}
