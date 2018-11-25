using System;

namespace _18_Task_Spyral_Matrix_2_dimension_array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която по дадено число n, извежда матрица във формата на спирала. Пример при n=4:
             * 1	2	3	4
             * 12	13	14	5
             * 11	16	15	6
             * 10	9	8	7
             *Упътване: Трябва да използвате двумерен масив.*/

            Console.Write("Enter N: ");
            int n = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int row = 0, col = 0, direction = 0;

            for (int i = 1; i <= n * n; i++)
            {
                switch (direction)
                {
                    case 0:
                        if (col > n - 1 || matrix[row, col] != 0)
                        {
                            direction = 1;
                            col--;
                            row++;
                        }
                        break;
                    case 1:
                        if (row > n - 1 || matrix[row, col] != 0)
                        {
                            direction = 2;
                            row--;
                            col--;
                        }
                        break;
                    case 2:
                        if (col < 0 || matrix[row, col] != 0)
                        {
                            direction = 3;
                            col++;
                            row--;
                        }
                        break;
                    case 3:
                        if (row < 0 || matrix[row, col] != 0)
                        {
                            direction = 0;
                            row++;
                            col++;
                        }
                        break;
                }

                matrix[row, col] = i;

                switch (direction)
                {
                    case 0: col++; break;
                    case 1: row++; break;
                    case 2: col--; break;
                    case 3: row--; break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < 10) Console.Write("{0}  ", matrix[i, j]);
                    else Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}