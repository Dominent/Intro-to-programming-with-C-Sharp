using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForVal7
{
    class CheckForVal7
    {
        static void Main(string[] args)
        {
            int val1;
            int result;
            val1 = Convert.ToInt32(Console.ReadLine());

            result = val1 / 100;

            if(result % 10 == 7)
                Console.WriteLine("the third number of:  " + val1 + "  is 7");
            else
                Console.WriteLine("the third number of:  " + val1 + "  is:  " + (result % 10));
            
            //double pow;
            
            //val1 = Convert.ToInt32(Console.ReadLine());
            

            //for (int i = 0; i < 10; ++i)
            //{

            //    pow = Math.Pow(10, i);

            //    a[i] = val1 / (int)pow;

            //}

            //if (a[2] == 7)
            //    Console.WriteLine("the third number of:  " + val1 + "  is 7");
            //else
            //    Console.WriteLine("the third number of:  " + val1 + "  is:  " + a[2]);
                      
            
        }
    }
}
