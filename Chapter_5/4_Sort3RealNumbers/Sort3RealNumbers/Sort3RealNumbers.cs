using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort3RealNumbers
{
    class Sort3RealNumbers
    {
        static void Main(string[] args)
        {
            int val1, val2, val3;
            val1 = val2 = val3 = 0;
            int firstPos;

            Console.WriteLine("Enter val1: ");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter val2: ");
            val2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter val3: ");
            val3 = Convert.ToInt32(Console.ReadLine());

            firstPos = val1;
            if(val1 > val2&&val1 > val3)
            {
                if (val2 > val3)
                {
                    Console.WriteLine("{0} {1} {2} ", firstPos, val2, val3);
                }
                else if(val3 > val2)
                {
                    Console.WriteLine("{0} {1} {2} ", firstPos, val3, val2);
                }
                else // val2 == val3
                {
                    Console.WriteLine("{0} {1} {2} ", firstPos, val2, val2);
                }
            }
            else if(val2 > val1 && val2 > val3)
            {
                firstPos = val2;
                if (val1 > val3)
                {
                    Console.WriteLine("{0} {1} {2} ", firstPos, val1, val3);
                }
                else if (val3 > val1)
                {
                    Console.WriteLine("{0} {1} {2} ", firstPos, val3, val1);
                }
                else //val3 == val1
                {
                    Console.WriteLine("{0} {1} {2} ", firstPos, val3, val3);
                }
                    
            }
            else if(val3 > val1 && val3 > val2)
            {
                firstPos = val3;
                if(val1 > val2)
                {
                    Console.WriteLine("{0} {1} {2} ", firstPos, val1, val2);
                }
                else if(val2 > val1)
                {
                    Console.WriteLine("{0} {1} {2} ", firstPos, val2, val1);
                }
                else //val1 == val2
                {
                    Console.WriteLine("{0} {1} {2} ", firstPos, val1, val1);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2} ", val1, val2, val3);  // All are Equal
            }
           



        }
    }
}
