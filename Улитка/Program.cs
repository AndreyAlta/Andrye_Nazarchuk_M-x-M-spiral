using System;

namespace Улитка
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, i, j, k, p, predel_j, predel_i;
            Console.Write("Введите количество строчек: ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Введите корректно количество строчек: ");
            }
            Console.Write("Введите количество столбцов: ");
            while (!int.TryParse(Console.ReadLine(), out m))
            {
                Console.Write("Введите корректно количество столбцов: ");
            }
            int[,] matrix = new int[n, m];
            i = 0;
            j = 0;
            k = 1;
            p = 0;
            while (n > (matrix.GetUpperBound(0) + 1) / 2 && m > (matrix.GetUpperBound(1) + 1) / 2)
            {
                for (; j < m; j++, k++)
                {
                    matrix[i, j] = k;
                }
                j--;
                i++;
                for (; i < n; i++, k++)
                {
                    matrix[i, j] = k;
                }
                i--;
                j--;
                predel_j = j + 1;
                for (; j > predel_j - n + p; j--, k++)
                {
                    matrix[i, j] = k;
                }
                j++;
                i--;
                predel_i = i + 1;
                for (; i >= n - predel_i + p; i--, k++)
                {
                    matrix[i, j] = k;
                }
                i++;
                n--;
                m--;
                j++;
                p++;
            }
            for (i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
