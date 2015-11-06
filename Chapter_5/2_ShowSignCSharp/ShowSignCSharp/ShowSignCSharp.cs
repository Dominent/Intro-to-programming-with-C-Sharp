using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowSignCSharp
{
    class ShowSignCSharp
    {
        static void Main(string[] args)
        {
            int val1, val2, val3;
            val1 = val2 = val3 = 0;
            int negativeCount = 0;
            int sum = 0;
             
            Console.WriteLine("Enter Val1: ");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Val2: ");
            val2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Val3: ");
            val3 = Convert.ToInt32(Console.ReadLine());

            sum = val1 + val2 + val3;

            if(val1 < 0)
            {
                negativeCount++;
            }
            if (val2 < 0)
            {
                negativeCount++;
            }
            if (val3 < 0)
            {
                negativeCount++;
            }
            if(val1 == 0 && val2 == 0&& val3 ==0)
            {
                negativeCount = 4;
            }
            
            switch (negativeCount)
            {
                case 0:
                    {
                        Console.WriteLine("Val1: {0} : Val2: {1} : Val3: {2} : Sum: {3}", val1, val2, val3, sum);
                        Console.WriteLine("The Sign Is:  *+* ");
                    }
                    break;
                case 1:
                    {
                        Console.WriteLine("Val1: {0} : Val2: {1} : Val3: {2} : Sum: {3}", val1, val2, val3,sum);
                        Console.WriteLine("The Sign Is:  *-* ");
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Val1: {0} : Val2: {1} : Val3: {2} : Sum: {3}", val1, val2, val3, sum);
                        Console.WriteLine("The Sign Is:  *+* ");
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Val1: {0} : Val2: {1} : Val3: {2} : Sum: {3}", val1, val2, val3, sum);
                        Console.WriteLine("The Sign Is:  *-* ");
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Val1: {0} : Val2: {1} : Val3: {2} : Sum: {3}", val1, val2, val3, sum);
                        Console.WriteLine("No Sign");
                    }
                    break;
                default:
                    Console.WriteLine("Something Went Wrong ");
                    break;
            
            }
            
        }
    }
}
