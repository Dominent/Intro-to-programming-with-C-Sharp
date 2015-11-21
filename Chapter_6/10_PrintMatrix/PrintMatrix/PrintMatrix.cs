using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMatrix
{
    class PrintMatrix
    {
        static void Main(string[] args)
        {
            int valN = 0;

            Console.WriteLine("Enter N:");
            valN = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= valN; ++i)
            {
                Console.Write("{0}", i);
                for (int j = i + 1; j <= valN + (i - 1); ++j)
                {
                    Console.Write(" {0}", j);
                }
                Console.WriteLine();
            }
        }
    }
}
