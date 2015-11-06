using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertsNumbersToStrings
{
    class ConvertsNumbersToStrings
    {
        static void Main(string[] args)
        {
            int val1 = 0;
            int hundreds = 0;
            int decimals = 0;
            int ones = 0;


            for (int i = 0; i < 1; ++i)
            {
                try
                {
                    Console.WriteLine("Enter a Number: ");
                    val1 = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bad Input.");
                    --i;
                }
            }
            if (val1 <= 999 && val1 >= 0)
            {
                hundreds = val1 / 100;
                decimals = (val1 / 10) % 10;
                ones = val1 % 10;

                switch (hundreds)
                {
                    case 0:
                        break;
                    case 1: Console.Write("Сто");
                        break;
                    case 2: Console.Write("Двеста");
                        break;
                    case 3: Console.Write("Триста");
                        break;
                    case 4: Console.Write("Четиристотин");
                        break;
                    case 5: Console.Write("Петстотин");
                        break;
                    case 6: Console.Write("Шестотин");
                        break;
                    case 7: Console.Write("Седемстотин");
                        break;
                    case 8: Console.Write("Осемстотин");
                        break;
                    case 9: Console.Write("Деветстотин");
                        break;
                }
                if ((decimals == 0) && (hundreds != 0))
                {
                    switch (ones)
                    {
                        case 0:
                            break;
                        case 1: Console.Write(" и едно");
                            break;
                        case 2: Console.Write(" и две");
                            break;
                        case 3: Console.Write(" и три");
                            break;
                        case 4: Console.Write(" и четири");
                            break;
                        case 5: Console.Write(" и пет");
                            break;
                        case 6: Console.Write(" и шест");
                            break;
                        case 7: Console.Write(" и седем");
                            break;
                        case 8: Console.Write(" и осем");
                            break;
                        case 9: Console.Write(" и девет");
                            break;
                    }
                }
                else
                {
                    switch (decimals)
                    {
                        case 0:
                            break;
                        case 1:
                            {
                                switch (ones)
                                {
                                    case 0: Console.WriteLine(" и десет");
                                        break;
                                    case 1: Console.WriteLine(" и еднинадесет");
                                        break;
                                    case 2: Console.WriteLine(" и двенеадесет");
                                        break;
                                    case 3: Console.WriteLine(" и тринадесет");
                                        break;
                                    case 4: Console.WriteLine(" и четиринадесет");
                                        break;
                                    case 5: Console.WriteLine(" и петнадесет");
                                        break;
                                    case 6: Console.WriteLine(" и шестнадесет");
                                        break;
                                    case 7: Console.WriteLine(" и седемнадесет");
                                        break;
                                    case 8: Console.WriteLine(" и осемнадесет");
                                        break;
                                    case 9: Console.WriteLine(" и деветнадесет");
                                        break;
                                }
                            }
                            break;
                        case 2:
                            {
                                if (ones == 0)
                                {
                                    Console.Write(" и двадесет");
                                }
                                else
                                {
                                    Console.Write(" двадесет и ");
                                }

                            }
                            break;
                        case 3:
                            {
                                if (ones == 0)
                                {
                                    Console.Write(" и тридесет");
                                }
                                else
                                {
                                    Console.Write(" тридесет и ");
                                }
                            }
                            break;
                        case 4:
                            {
                                if (ones == 0)
                                {
                                    Console.Write(" и четиредесет");
                                }
                                else
                                {
                                    Console.Write(" четиредесет и ");
                                }
                            }
                            break;
                        case 5:
                            {
                                if (ones == 0)
                                {
                                    Console.Write(" и петдесет");
                                }
                                else
                                {
                                    Console.Write(" петдесет и ");
                                }
                            }
                            break;
                        case 6:
                            {
                                if (ones == 0)
                                {
                                    Console.Write(" и шестдесет");
                                }
                                else
                                {
                                    Console.Write(" шестдесет и ");
                                }
                            }
                            break;
                        case 7:
                            {
                                if (ones == 0)
                                {
                                    Console.Write(" и седемдесет");
                                }
                                else
                                {
                                    Console.Write(" седемдесет и ");
                                }
                            }
                            break;
                        case 8:
                            {
                                if (ones == 0)
                                {
                                    Console.Write(" и осемдесет");
                                }
                                else
                                {
                                    Console.Write(" осемдесет и ");
                                }
                            }
                            break;
                        case 9:
                            {
                                if (ones == 0)
                                {
                                    Console.Write(" и деветдесет");
                                }
                                else
                                {
                                    Console.Write(" деветдесет и ");
                                }
                            }
                            break;
                    }

                    if ((decimals == 0) && (hundreds == 0))
                    {
                        switch (ones)
                        {
                            case 1: Console.WriteLine("Едно");
                                break;
                            case 2: Console.WriteLine("Две");
                                break;
                            case 3: Console.WriteLine("Три");
                                break;
                            case 4: Console.WriteLine("Четири");
                                break;
                            case 5: Console.WriteLine("Пет");
                                break;
                            case 6: Console.WriteLine("Шест");
                                break;
                            case 7: Console.WriteLine("Седем");
                                break;
                            case 8: Console.WriteLine("Осем");
                                break;
                            case 9: Console.WriteLine("Девет");
                                break;
                            default: Console.WriteLine("Нула");
                                break;
                        }
                    }
                }
            }
        }
    }
}
