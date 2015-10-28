using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckThirdBit
{
    class CheckThirdBit
    {
        static void Main(string[] args)
        {
            //int test1;
            //int test2;
            //int resultAnd;
            //int resultOr;
            //string NumberBinaryString1;
            //string NumberBinaryString2;


            //while(true)
            //{
            //    test1 = Convert.ToInt32(Console.ReadLine());

            //    test2 = Convert.ToInt32(Console.ReadLine());

            //    NumberBinaryString1 = Convert.ToString(test1, 2);
            //    NumberBinaryString2 = Convert.ToString(test2, 2);

            //    resultAnd = test1 & test2;
            //    resultOr = test1 | test2;

            //    Console.WriteLine("\t test1: " + NumberBinaryString1);
            //    Console.WriteLine("\t test2: " + NumberBinaryString2);

            //    Console.WriteLine("\t resultAnd: " + resultAnd);
            //    Console.WriteLine("\t resultOr: " + resultOr);

            //}


            int val1;
                     
            val1 = Convert.ToInt32(Console.ReadLine());

            int val2 = val1 & 4;

            if (val2 == 4)
                Console.WriteLine("The 3rd Bit is 1");
            else
                Console.WriteLine("The 3rd Bit is [0]");


        }
    }
}
