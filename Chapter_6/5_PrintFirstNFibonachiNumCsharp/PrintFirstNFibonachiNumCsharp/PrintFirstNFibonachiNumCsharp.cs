using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFirstNFibonachiNumCsharp
{
    class PrintFirstNFibonachiNumCsharp
    {
        static void Main(string[] args)
        {
            int valN;
            int[] fiboNumbers;
            int sum = 1; //fiboNumbers[0] + fiboNumbers[1];

            Console.WriteLine("Enter N: ");
            valN = Convert.ToInt32(Console.ReadLine());

            fiboNumbers = new int[valN];

            for (int i = 0; i < valN; ++i)
            {
                if (i == 0 || i == 1)
                {
                    fiboNumbers[0] = 0;
                    fiboNumbers[1] = 1;
                    Console.WriteLine("Fibonachi Numbers:{0}", fiboNumbers[i]);
                }
                else
                {
                    fiboNumbers[i] = fiboNumbers[i - 1] + fiboNumbers[i - 2];
                    Console.WriteLine("Fibonachi Numbers:{0}", fiboNumbers[i]);
                    sum = fiboNumbers[i] + sum;
                }
            }
            Console.WriteLine("Sum = {0}", sum);
        }
    }
}
