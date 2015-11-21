using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexCSharp
{
    class DecimalToHexCSharp
    {
        static void Main(string[] args)
        {
            string input;
            int valN = 0;
            int[] numbers;

            Console.WriteLine("Enter Number: ");
            input = Console.ReadLine();
            valN = Convert.ToInt32(input);

            numbers = new int[input.Length + 1];

            for (int i = 0; i <= input.Length; ++i)
            {
                numbers[i] = valN % 16;
                valN = valN / 16;
            }
            for (int i = input.Length; 0 <= i; --i)
            {
                if (numbers[i] >= 10)
                {
                    switch (numbers[i])
                    {
                        case 10: Console.Write("A");
                            break;
                        case 11: Console.Write("B");
                            break;
                        case 12: Console.Write("C");
                            break;
                        case 13: Console.Write("D");
                            break;
                        case 14: Console.Write("E");
                            break;
                        case 15: Console.Write("F");
                            break;
                    }
                }
                else
                {
                    Console.Write(" {0}", numbers[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
