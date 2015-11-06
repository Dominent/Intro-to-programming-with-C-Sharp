using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class BonusPoints
    {
        static void Main(string[] args)
        {
            int points;

            while(true)
            {
                Console.WriteLine("Enter a Number: ");
                points = Convert.ToInt32(Console.ReadLine());
                switch(points)
                {
                    case 0: Console.WriteLine("Wrong Input");
                        break;
                    case 1:
                    case 2:
                    case 3: Console.WriteLine("Points: {0}", (points * 10));
                        break;
                    case 4:
                    case 5:
                    case 6: Console.WriteLine("Points: {0}", (points * 100));
                        break;
                    case 7:
                    case 8:
                    case 9: Console.WriteLine("Points: {0}", (points * 1000));
                        break;
                    default: Console.WriteLine("Wrong Input");
                        break;

                }
            }
        }
    }
}
