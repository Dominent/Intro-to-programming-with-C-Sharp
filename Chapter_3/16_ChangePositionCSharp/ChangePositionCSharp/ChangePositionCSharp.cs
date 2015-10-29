using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangePositionCSharp
{
    class ChangePositionCSharp
    {
        static void Main(string[] args)
        {
            int i = 1;
            int valN = 0;
            Console.WriteLine("Enter a number: ");
            valN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter P: ");
            Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter K: ");
            Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Q: ");
            int endQ = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Convert.ToString(valN, 2));
            int[] maskBit = new int[endQ];
            int[] checkBit = new int[endQ];
            for (int j = 0; j <= endQ; j++)
            {
                maskBit[j] = i << (j & 31);
                checkBit[j] = ((valN & maskBit[j]) != 0 ? 1 : 0);
            }
            for (int k = 0; k <= endQ; k++)
            {
                if (checkBit[k] != 0)
                {
                    valN = valN | 1 << (endQ + k & 31);
                    Console.WriteLine(valN);
                }
                else
                {
                    valN = valN & ~(1 << (endQ + k & 31));
                    Console.WriteLine(valN);
                }
            }
        }
    }
}
