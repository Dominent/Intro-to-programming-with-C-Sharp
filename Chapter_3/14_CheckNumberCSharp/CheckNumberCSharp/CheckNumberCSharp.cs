using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckNumberCSharp
{
    class CheckNumberCSharp
    {
        static void Main(string[] args)
        {
            int val1;
            bool isPrime = false;
            val1 = Convert.ToInt32(Console.ReadLine());



            if (val1 < 100 && val1 > 1)
            {
                for (int i = 1; i < 100; i++)
                {
                    if (i != 1 && i != val1)
                    {
                        if (val1 % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                        else
                        {
                            isPrime = true;
                            break;
                        }
                    }
                }
                if (isPrime)
                    Console.WriteLine(val1 + " is a Prime Number.");
                else
                    Console.WriteLine(val1 + " is Not a Prime Number.");
            }
            else
                Console.WriteLine("Bad Input.");

        }
    }
}
