using System;

namespace _07_Task_Almost_same_as_Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която пресмята N!*K!/(N-K)! за дадени N и K (1 < K < N).
             *Упътване: Вариант за решение е поотделно да пресмятате всеки от факто­риелите и накрая
             *да извършвате съответните операции с резултатите. Помис­лете как можете да оптимизирате пресмятанията,
             *за да не смятате прекалено много факториели! При обикновени дроби, съставени от факто­риели има много възможности
             *за съкращение на еднакви множи­тели в числителя и знаменателя.
             *Тези оптимизации не само ще нама­лят изчисленията и ще увеличат производителността,
             *но ще ви избавят и от препълвания в някои ситуации.*/


            Console.Write("Enter N: (1<K<N) ");
            int N = Int32.Parse(Console.ReadLine());

            Console.Write("Enter K: (1<K<N) ");
            int K = Int32.Parse(Console.ReadLine());
            int N_K = N - K;

            for (int i = N - 1; i > 0; i--) N *= i;
            for (int i = K - 1; i > 0; i--) K *= i;
            for (int i = N_K - 1; i > 0; i--) N_K *= i;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("The result is: {0}", N * K / N_K);
            Console.ResetColor();

        }
    }
}
