using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonachiNumbers
{
    class FibonachiNumbers
    {
        static void Main(string[] args)
        {
            long [] fibonachiVal;

            fibonachiVal = new long [100];

            fibonachiVal[0] = 1;
            fibonachiVal[1] = 1;

            for (int i = 2; i <= 88; ++i)
                fibonachiVal[i] = fibonachiVal[i - 1] + fibonachiVal[i-2];
            for (int i = 0; i <= 88; i++)
                Console.WriteLine("{0} Number of the Fibonachi Sequence is : {1}",i+1, fibonachiVal[i]);

            // Only huh 89 numbers we are OverFlowing the Long :D


        }
    }
}
