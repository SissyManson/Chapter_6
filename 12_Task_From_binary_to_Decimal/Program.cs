using System;

namespace _12_Task_From_binary_to_Decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която преобразува дадено число от десетична в двоична бройна система.
             * Упътване: Прочетете в Уикипедия какво представляват бройните системи.*/

            Console.Write("Enter number: ");
            int n = Int32.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2);
            Console.WriteLine("Result is {0}", binary);
        }
    }
}
