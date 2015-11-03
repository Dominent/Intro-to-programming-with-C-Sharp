using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigOrSmall5NumbersCSharp
{
    class BigOrSmall5NumbersCSharp
    {
        static void Main(string[] args)
        {
            int[] values;
            values = new int[5];
            int temp = 0;

            for (int i = 0; i <= 4; ++i)
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
                if (temp < values[i])
                    temp = values[i];
            }
            Console.WriteLine("The biggest Number is: {0}", temp);

        }
    }
}
