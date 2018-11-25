using System;

namespace _13_Task_From_Dec_to_Bin
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която преобразува дадено число от двоична в десетична бройна система.
             * Упътване: Погледнете предходната задача.*/

            Console.Write("Enter binary number: ");
            int n = Int32.Parse(Console.ReadLine());
            string toDecimal = Convert.ToInt32(n, 2).ToString();//idk how to repair it
            Console.WriteLine("Result is {0}", toDecimal);
        }
    }
}
