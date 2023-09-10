using System;

class Program
{
    static void Main()
    {
        Console.Clear(); // Очистка терминала

        // Задайте двумерный массив
        int[,] array = {
            {8, 4, 6, 2},
            {5, 8, 2, 3},
            {3, 7, 2, 4}
        };

        // Упорядочиваем элементы каждой строки по возрастанию
        SortRowsAscending(array);

        // Выводим упорядоченный массив
        PrintArray(array);
    }

    // Метод для сортировки элементов каждой строки по возрастанию
    static void SortRowsAscending(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                for (int k = j + 1; k < array.GetLength(1); k++)
                {
                    if (array[i, k] < array[i, j])
                    {
                        // Обмен элементов, если текущий элемент меньше следующего
                        int temp = array[i, j];
                        array[i, j] = array[i, k];
                        array[i, k] = temp;
                    }
                }
            }
        }
    }

    // Метод для вывода массива
    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
