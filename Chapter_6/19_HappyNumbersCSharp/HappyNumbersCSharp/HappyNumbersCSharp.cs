using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyNumbersCSharp
{
    class HappyNumbersCSharp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program shows all the happy numbers:");
            Console.WriteLine();

            for (int a = 0; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    for (int c = 0, d = 0; c <= 9; d++)
                    {
                        if (d > 9)
                        {
                            c++;
                            d = -1;
                        }
                        else if ((a + b) == (c + d))
                        {
                            Console.WriteLine(a + " " + b + " " + c + " " + d);
                        }
                    }
                }
            }
        }
    }
}
