using System;

namespace _01_Task_Entering_N_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Напишете програма, която отпечатва на конзолата числата от 1 до N. Числото N трябва да се чете от стандартния вход.
             * Упътване: Използвайте for цикъл.
             */
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Enter how many numbers you want me to print: ");
            Console.ResetColor();

            int length = Int32.Parse(Console.ReadLine());
                for (int i = 1; i < length; i++)
                    Console.WriteLine(i);
            
        }
    }
}
