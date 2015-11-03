using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteNNumberCSharp
{
    class WriteNNumberCSharp
    {
        static void Main(string[] args)
        {
            int[] values;
            int n = 0;
            int sum = 0;

            Console.WriteLine("Enter N: ");
            n = Convert.ToInt32(Console.ReadLine());
            values = new int[n];

            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine("Enter {0} Number : ", i + 1);
                try
                {
                    values[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a Whole Number!");
                    --i; // HackFix :D 
                    continue;

                }
                sum += values[i];
            }
            Console.WriteLine("The sum of all 5 numbers is : {0}", sum);
            for (int i = 0; i < n; ++i)
                Console.WriteLine("{0} Number : {1}", (i + 1), values[i]);
        }
    }
}
