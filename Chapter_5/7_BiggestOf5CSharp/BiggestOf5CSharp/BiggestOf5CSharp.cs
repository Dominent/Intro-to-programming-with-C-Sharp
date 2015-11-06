using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOf5CSharp
{
    class BiggestOf5CSharp
    {
        static void Main(string[] args)
        {
            int val1, val2, val3, val4, val5;
            val1 = val2 = val3 = val4 = val5 = 0;
            int biggestVal;

            Console.WriteLine("Enter val1: ");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter val2: ");
            val2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter val3: ");
            val3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter val4: ");
            val4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter val5: ");
            val5 = Convert.ToInt32(Console.ReadLine());


            if (val1 > val2 && val1 > val3 && val1 > val4 && val1 > val5)
            {
                biggestVal = val1;
                Console.WriteLine("The Biggest Value is: {0}", biggestVal);
            }
            else if (val2 > val1 && val2 > val3 && val2 > val4 && val2 > val5)
            {
                biggestVal = val2;
                Console.WriteLine("The Biggest Value is: {0}", biggestVal);
            }
            else if (val3 > val1 && val3 > val2 && val3 > val4 && val3 > val5)
            {
                biggestVal = val3;
                Console.WriteLine("The Biggest Value is: {0}", biggestVal);
            }
            else if (val4 > val1 && val4 > val2 && val4 > val3 && val4 > val5)
            {
                biggestVal = val4;
                Console.WriteLine("The Biggest Value is: {0}", biggestVal);
            }
            else if (val5 > val1 && val5 > val2 && val5 > val3 && val5 > val4)
            {
                biggestVal = val5;
                Console.WriteLine("The Biggest Value is: {0}", biggestVal);
            }
            else
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", val1, val2, val3, val4, val5);  // All are Equal
            }
           
        }
    }
}
