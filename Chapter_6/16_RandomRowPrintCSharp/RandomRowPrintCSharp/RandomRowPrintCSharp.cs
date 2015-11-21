using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Fisher - Yates Method
namespace RandomRowPrintCSharp
{
    class RandomRowPrintCSharp
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int valN;
            valN = Convert.ToInt32(Console.ReadLine());
            int[] numbers;
                        
            numbers = new int[valN];
                       
            for (int i = 0; i < valN; ++i)
            {
                numbers[i] = i + 1;
            }
            Console.WriteLine();
            for (int i = 0; i < valN; i++)
            {
                int j = i + (int)(r.NextDouble()*(valN - i));
                int k = numbers[j];
                numbers[j] = numbers[i];
                numbers[i] = k;
                              
                Console.WriteLine(" " + numbers[i]);
            }
        }
    }
}