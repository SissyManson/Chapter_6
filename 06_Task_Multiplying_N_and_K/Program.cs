using System;

namespace _06_Task_Multiplying_N_and_K
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която пресмята N!/K! за дадени N и K (1 < k < N).
             * Упътване: Умножете числата от K+1 до N.*/

            Console.Write("Enter K: (1<K<N) ");
            int K = Int32.Parse(Console.ReadLine());

            Console.Write("Enter N: (1<K<N) ");
            int N = Int32.Parse(Console.ReadLine());

            for (int i = N - 1; i > 0; i--)
            {
                N *= i;
            }

            for (int i = K - 1; i > 0; i--)
            {
                K *= i;
            }

            N /= K;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("The result is: {0}", N);
            Console.ResetColor();
        }
    }
}
