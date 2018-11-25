using System;

namespace _03_Task_Min_and_max_number
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Напишете програма, която чете от конзолата поредица от цели числа и отпечатва най-малкото и най-голямото от тях.
             Упътване: Първо прочетете броя числа, примерно в променлива n. След това въведете n числа последователно с един for цикъл.
             Докато въвеждате всяко следващо число запазвайте в две променливи най-малкото и най-голямото число до момента.
             */
            int min = 0, max = 0, n;

            Console.Write("Enter how many numbers you want: ");
            int length = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter those {0} numbers: ",length);
                n = Int32.Parse(Console.ReadLine());

                if (i == 0) min = max = n;
                else
                {
                    if (min > n) min = n;
                    if (max < n) max = n;
                }
            }

            Console.WriteLine("Smallest number: {0}\nBiggest number: {1}", min, max);
        }
    }
}
