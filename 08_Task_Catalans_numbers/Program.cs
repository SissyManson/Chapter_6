using System;

namespace _08_Task_Catalans_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*В комбинаториката числата на Каталан (Catalan’s numbers) се изчис­ляват по следната формула:...., за n ≥ 0.
             * Напишете програма, която изчислява n-тото число на Каталан за дадено n.
             * Упътване: Погледнете предходната задача.*/

            int n;
            do
            {
                Console.Write("Enter N: (N >=0 ) ");
             n = Int32.Parse(Console.ReadLine());
            } while (n < 0);

            int fact2N = 2 * n, factNplus1 = n + 1;

            for (int i = fact2N - 1; i > 0; i--) fact2N *= i;
            for (int i = factNplus1 - 1; i > 0; i--) factNplus1 *= i;
            for (int i = n - 1; i > 0; i--) n *= i;

            Console.WriteLine("Result is {0}", fact2N / (factNplus1 * n));
        }
    }
}
