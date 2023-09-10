// Подключение пространства имен System, которое содержит основные классы и методы для взаимодействия с консолью и другими стандартными функциями.
using System;

// Объявление пространства имен для нашего приложения.
namespace ConsoleApp1
{
    // Объявление класса Program.
    internal class Program
    {
        // Главный метод Main, который является точкой входа в программу.
        static void Main(string[] args)
        {
            // Очистка терминала перед выводом.
            Console.Clear();

            // Объявление и инициализация первой матрицы.
            int[,] matrix1 =
            {
                {1, 4, 7, 2},
                {5, 9, 2, 3},
                {8, 4, 2, 4},
                {5, 2, 6, 7}
            };

            // Объявление и инициализация второй матрицы.
            int[,] matrix2 =
            {
                {1, 5, 8, 5},
                {4, 9, 4, 2},
                {7, 2, 2, 6},
                {2, 3, 4, 7}
            };

            // Создание матрицы для хранения результата умножения.
            int[,] multiplyMatrix = new int[4, 4];

            // Вывод на консоль информации о матрице 1.
            Console.WriteLine("Значения матрицы 1:");

            // Вызов функции для вывода матрицы на консоль.
            PrintMatrix(matrix1);

            // Вывод на консоль информации о матрице 2.
            Console.WriteLine("\nЗначения матрицы 2:");

            // Вызов функции для вывода матрицы на консоль.
            PrintMatrix(matrix2);

            // Вызов функции для умножения матриц.
            MultiplyMatrices(matrix1, matrix2, multiplyMatrix);

            // Вывод на консоль информации о результате умножения.
            Console.WriteLine("\nПроизведение двух матриц:");

            // Вызов функции для вывода результирующей матрицы на консоль.
            PrintMatrix(multiplyMatrix);
        }

        static void MultiplyMatrices(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
        {
            // Цикл по строкам матрицы.
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                // Цикл по столбцам матрицы.
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    // Умножение соответствующих элементов и сохранение результата.
                    resultMatrix[i, j] = matrix1[i, j] * matrix2[i, j];
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            // Цикл по строкам матрицы.
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                // Цикл по столбцам матрицы.
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // Вывод элемента матрицы на консоль с разделителем.
                    Console.Write(matrix[i, j] + "\t");
                }
                // Переход на новую строку для вывода следующей строки матрицы.
                Console.WriteLine();
            }
        }
    }
}
