using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDeckCardsCSharp
{
    class PrintDeckCardsCSharp
    {
        static void Main(string[] args)
        {
            int[] cards;
            int[] cardsColors;

            cards = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 }; //11[J], 12[Q], 13[K], 14[A]
            cardsColors = new int[] { 1, 2, 3, 4 }; //1 - Clubs, 2 - Diamonds, 3 - Hearts, 4 - Spades
            for (int j = 0; j < 4; ++j)
            {
                for (int i = 0; i <= 12; ++i)
                {
                    if (cards[i] > 10 && cards[i] <= 14)
                    {
                        switch (cards[i])
                        {
                            case 11: Console.Write("Jack");
                                break;
                            case 12: Console.Write("Queen");
                                break;
                            case 13: Console.Write("King");
                                break;
                            case 14: Console.Write("Ace");
                                break;
                        }
                    }
                    else
                    {
                        Console.Write("{0}", cards[i]);
                    }
                    switch (cardsColors[j])
                    {
                        case 1: Console.WriteLine(" of Clubs");
                            break;
                        case 2: Console.WriteLine(" of Diamonds");
                            break;
                        case 3: Console.WriteLine(" of Hearts");
                            break;
                        case 4: Console.WriteLine(" of Spades");
                            break;

                    }
                }
            }
        }
    }
}
