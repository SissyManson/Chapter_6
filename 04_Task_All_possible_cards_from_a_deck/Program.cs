using System;

namespace _04_Task_All_possible_cards_from_a_deck
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Напишете програма, която отпечатва всички възможни карти от стан­дартно тесте карти без джокери
             * (имаме 52 карти: 4 бои по 13 карти).
             * Упътване: Номерирайте картите от 2 до 14 (тези числа ще съответстват на картите от 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A).
             * Номерирайте боите от 1 до 4 (1 – спатия, 2 – каро, 3 – купа, 4 – пика).
             * Сега вече можете да завъртите 2 вложени цикъла и да отпечатате всяка от картите.
             */
            for (int i = 0; i < 4; i++)
            {
                if (i != 0) Console.WriteLine();

                for (int j = 0; j < 13; j++)
                {
                    switch (i)
                    {
                        case 0: Console.Write("Clubs "); break;
                        case 1: Console.Write("Diamonds "); break;
                        case 2: Console.Write("Hearts "); break;
                        case 3: Console.Write("Spades "); break;
                    }
                    switch (j)
                    {
                        case 0: Console.WriteLine("2"); break;
                        case 1: Console.WriteLine("3"); break;
                        case 2: Console.WriteLine("4"); break;
                        case 3: Console.WriteLine("5"); break;
                        case 4: Console.WriteLine("6"); break;
                        case 5: Console.WriteLine("7"); break;
                        case 6: Console.WriteLine("8"); break;
                        case 7: Console.WriteLine("9"); break;
                        case 8: Console.WriteLine("10"); break;
                        case 9: Console.WriteLine("J"); break;
                        case 10: Console.WriteLine("Q"); break;
                        case 11: Console.WriteLine("K"); break;
                        case 12: Console.WriteLine("A"); break;
                    }
                }
            }
            Console.ReadLine(); for (int i = 0; i < 4; i++)
            {
                if (i != 0) Console.WriteLine();

                for (int j = 0; j < 13; j++)
                {
                    switch (i)
                    {
                        case 0: Console.Write("Clubs "); break;
                        case 1: Console.Write("Diamonds "); break;
                        case 2: Console.Write("Hearts "); break;
                        case 3: Console.Write("Spades "); break;
                    }
                    switch (j)
                    {
                        case 0: Console.WriteLine("2"); break;
                        case 1: Console.WriteLine("3"); break;
                        case 2: Console.WriteLine("4"); break;
                        case 3: Console.WriteLine("5"); break;
                        case 4: Console.WriteLine("6"); break;
                        case 5: Console.WriteLine("7"); break;
                        case 6: Console.WriteLine("8"); break;
                        case 7: Console.WriteLine("9"); break;
                        case 8: Console.WriteLine("10"); break;
                        case 9: Console.WriteLine("J"); break;
                        case 10: Console.WriteLine("Q"); break;
                        case 11: Console.WriteLine("K"); break;
                        case 12: Console.WriteLine("A"); break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
