using System;

class Program
{
    static void Main()
    {
        Console.Clear(); // Очистка терминала

        int n = 4;
        int[,] spiralArray = new int[n, n];

        int num = 1;
        int row = 0, col = 0;
        int rowStart = 0, rowEnd = n - 1, colStart = 0, colEnd = n - 1;

        while (num <= n * n)
        {
            // Вправо
            for (int i = colStart; i <= colEnd; i++)
            {
                spiralArray[row, i] = num++;
            }
            row++;

            // Вниз
            for (int i = row; i <= rowEnd; i++)
            {
                spiralArray[i, colEnd] = num++;
            }
            colEnd--;

            // Влево
            for (int i = colEnd; i >= colStart; i--)
            {
                spiralArray[rowEnd, i] = num++;
            }
            rowEnd--;

            // Вверх
            for (int i = rowEnd; i >= row; i--)
            {
                spiralArray[i, colStart] = num++;
            }
            colStart++;
        }

        // Выводим спиральный массив 4x4
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{spiralArray[i, j],2} ");
            }
            Console.WriteLine();
        }
    }
}
