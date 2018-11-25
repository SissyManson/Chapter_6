using System;

namespace _09_Task_N_number
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която за дадено цяло число n, пресмята сумата...
             * Упътване: Задачата може да решите с for-цикъл за k=0…n, като ползвате три допълнителни променливи factoriel, power и sum,
             * в които да пазите за k-тата итерация на цикъла съответно k!, xk и сумата на първите k члена на редицата.
             * Ако реализацията ви е добра, Трябва да имате само един цикъл и не трябва да ползвате външни функции за изчис­ление
             * на факториел и за степенуване.*/

            int sum = 1, temp = 1;
            Console.Write("Enter n: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter x: ");
            int x = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                temp *= i / x;
                sum += temp;
            }

            Console.WriteLine("Result is {0}", sum);
        }
    }
}
