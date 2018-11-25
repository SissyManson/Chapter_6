using System;

namespace _16_Task_N_random_nums
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която по дадено число N отпечатва числата от 1 до N, разбъркани в случаен ред.
             *Упътване: Потърсете в Интернет информация за класа System.Random. Прочетете в Интернет за масиви.
             *Направете масив с N елемента и запишете в него числата от 1 до N.
             *След това достатъчно много пъти (помислете точно колко) разменяйте двойки случайни числа от масива.string.*/

            Random rnd = new Random();
            int temp, randomNumber;
            Console.Write("Enter number: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            foreach (int i in arr)
            {
                randomNumber = rnd.Next(0, n);
                temp = arr[i];
                arr[i] = arr[randomNumber];
                arr[randomNumber] = temp;
            }

            foreach (int i in arr) Console.WriteLine(arr[i]);
        }
    }
}
