using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestNumOf3Charp
{
    class BiggestNumOf3Charp
    {
        static void Main(string[] args)
        {
            int val1, val2, val3;
            val1 = val2 = val3 = 0;
            int temp;

            Console.WriteLine("Enter val1: ");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter val2: ");
            val2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter val3: ");
            val3 = Convert.ToInt32(Console.ReadLine());

            temp = val1;

            if(val2 > temp)
            {
                temp = val2;
            }
            if(val3 > temp)
            {
                temp = val3;
            }
            Console.WriteLine("The Biggest Value of : {0}, {1}, {2} is :  {3}",val1, val2, val3, temp);

        }
    }
}
