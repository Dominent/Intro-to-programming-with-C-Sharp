using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNNumbersCSharp
{
    class PrintNNumbersCSharp
    {
        static void Main(string[] args)
        {
            int valN;
            Console.WriteLine("Enter N: ");

            valN = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < valN; ++i)
            {
                Console.WriteLine("{0}", i+1);
            }
        }
    }
}
