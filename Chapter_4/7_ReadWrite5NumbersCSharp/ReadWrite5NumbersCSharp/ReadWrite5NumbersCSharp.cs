using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWrite5NumbersCSharp
{
    class ReadWrite5NumbersCSharp
    {
        static void Main(string[] args)
        {
            int[] values;
            values = new int[5];
            int sum = 0;

            for(int i = 0;i <=4; ++i)
            {
                Console.WriteLine("Enter {0} Number : ", i+1);
                try
                {
                    values[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a Whole Number!");
                    --i; // HackFix :D 
                    continue;
                    
                }                                      
            }
            for(int i = 0;i <=4; ++i)
            {
                 Console.WriteLine("The {0} Number is : {1}", i+1,  values[i]);
                 sum += values[i];
            }
            Console.WriteLine("The sum of all 5 numbers is : {0}", sum);

        }
    }
}
