using System;

class Program
{
    static void Main()
    {
        // Задайте прямоугольный двумерный массив
        int[,] array = {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {0, 0, 2, 4},
            {5, 0, 6, 7}
        };

        // Найдем строку с наименьшей суммой элементов
        int minSumRow = FindRowWithMinSum(array);

        // Выведем номер строки с наименьшей суммой элементов
        Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRow + 1}");
    }

    // Метод для нахождения строки с наименьшей суммой элементов
    static int FindRowWithMinSum(int[,] array)
    {
        int minSum = int.MaxValue;
        int minSumRow = -1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int rowSum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minSumRow = i;
            }
        }

        return minSumRow;
    }
}
