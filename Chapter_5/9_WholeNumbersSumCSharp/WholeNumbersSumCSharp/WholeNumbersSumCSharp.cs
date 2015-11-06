using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WholeNumbersSumCSharp
{
    class WholeNumbersSumCSharp
    {
        static void Main(string[] args)
        {
            int[] numbers;
            numbers = new int[5];

            for (int i = 0; i < 5; ++i)
            {
                try
                {
                    Console.WriteLine("Enter Val{0}: ", i + 1);
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bad Input: ");
                    --i;
                }
            }
            GC.Collect();

            if (numbers[0] == 0 && numbers[1] == 0 && numbers[2] == 0 && numbers[3] == 0 && numbers[4] == 0)
            {
                Console.WriteLine("All Entered Values Are Equal to 0");
            }
            else
            {
                for (int k = 0; k < 5; ++k)
                {
                    for (int j = k + 1; j < 5; ++j)
                    {
                        if (numbers[k] + numbers[j] == 0)
                        {
                            Console.WriteLine("The Sum of {0} And {1} Equals 0", numbers[k], numbers[j]);
                        }

                        for (int l = j + 1; l < 5; ++l)
                        {
                            if ((numbers[k] + numbers[j]) + numbers[l] == 0)
                            {
                                Console.WriteLine("The Sum of {0} + {1} + {2} == 0", numbers[k], numbers[j], numbers[l]);
                            }

                            for (int h = l + 1; h < 5; ++h)
                            {
                                if ((numbers[k] + numbers[j] + numbers[l]) + numbers[h] == 0)
                                {
                                    Console.WriteLine("The Sum of {0} + {1} + {2} + {3} == 0", numbers[k], numbers[j], numbers[l], numbers[h]);
                                }

                                for (int g = h + 1; g < 5; ++g)
                                {
                                    if ((numbers[k] + numbers[j] + numbers[l] + numbers[h]) + numbers[g] == 0)
                                    {
                                        Console.WriteLine("The Sum of {0} + {1} + {2} + {3} + {4} == 0", numbers[k], numbers[j], numbers[l], numbers[h], numbers[g]);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

