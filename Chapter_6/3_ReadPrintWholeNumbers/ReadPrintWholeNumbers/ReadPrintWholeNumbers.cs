using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadPrintWholeNumbers
{
    class ReadPrintWholeNumbers
    {
        static void Main(string[] args)
        {
            int valN ;
            int[] numbers;
            int smallVal = 0;
            int bigVal = 0;

            Console.WriteLine("Enter N: ");
            valN = Convert.ToInt32(Console.ReadLine());

            numbers = new int[valN];
           
            for(int i = 0;i < valN; ++i)
            {
                
                Console.WriteLine("Enter {0} Number: ", i+1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());

                if( i == 0)
                {
                    smallVal = numbers[0];
                    bigVal = numbers[0];
                }
                if(smallVal > numbers[i])
                {
                    smallVal = numbers[i];
                }
                if (bigVal < numbers[i])
                {
                    bigVal = numbers[i];
                }

            }
            Console.WriteLine("The Biggest Number is: {0}", bigVal);
            Console.WriteLine("The Smallest Number is: {0}", smallVal);
        }
    }
}
