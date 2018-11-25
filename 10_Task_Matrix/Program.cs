using System;

namespace _10_Task_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която чете от конзолата положително цяло число N (N < 20) и отпечатва матрица с числа като на фигурата по-долу.
             * Упътване: Трябва да използвате два вложени цикъла, по подобие на задачата за отпечатване на триъгълник с числа.
             * Външният цикъл трябва да върти от 1 до N, а вътрешният – от стойността на външния до стойността на външния + N - 1.*/
            int n;
            do
            {
                Console.Write("Enter N: (N < 20) ");
                n = Int32.Parse(Console.ReadLine());
            } while (n > 20);

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }

        }
    }
}
