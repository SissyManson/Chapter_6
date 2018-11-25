using System;

namespace _02_Task_Entering_N_nubers__divided_by_3_n_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * . Напишете програма, която отпечатва на конзолата числата от 1 до N, които не се делят едновременно на 3 и 7. 
             * Числото N да се чете от стандартния вход.
             * Упътване: Използвайте for цикъл и оператора % за намиране на остатък при целочислено деление.
             * Едно число num не се дели на 3 и на 7 едновременно, ако (num % (3*7) == 0) .
             */
            Console.Write("Enter N: ");
            int N = Int32.Parse(Console.ReadLine());

            for (int i = 1; i < N; i++)
            {
                if (i % (3 * 7) != 0) Console.WriteLine(i);
            }
        }
    }
}
