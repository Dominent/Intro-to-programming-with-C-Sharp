using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideBy5And7NNumbers
{
    class DivideBy5And7NNumbers
    {
        static void Main(string[] args)
        {
            int valN;
            Console.WriteLine("Enter N: ");

            valN = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= valN; ++i)
            {
               if( i % 3 != 0 && i % 7 != 0)
               {
                   Console.WriteLine("{0}", i);
               }
              
            }
        }
    }
}
