using System;

class Program
{
    static void Main()
    {
        Console.Clear(); // Очистка терминала

        // Создаем объект генератора случайных чисел
        Random random = new Random();

        // Создаем трехмерный массив 2x2x2 для хранения чисел
        int[,,] arr3D = new int[2, 2, 2];

        // Создаем список для отслеживания уже использованных чисел
        var usedNumbers = new System.Collections.Generic.HashSet<int>();

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int k = 0; k < 2; k++)
                {
                    int randomNum;
                    do
                    {
                        // Генерируем случайное двузначное число
                        randomNum = random.Next(10, 100);
                    }
                    while (usedNumbers.Contains(randomNum)); // Проверяем, что число не повторяется

                    // Заполняем массив случайным числом
                    arr3D[i, j, k] = randomNum;
                    usedNumbers.Add(randomNum);

                    // Выводим число с индексами
                    Console.WriteLine($"{arr3D[i, j, k]}({i},{j},{k})");
                }
            }
        }
    }
}
