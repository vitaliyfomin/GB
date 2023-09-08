using System;

class Program
{
    static void Main()
    {
// Очистка терминала
        Console.Clear();

        Random random = new Random();
// Создаем массив из 4 элементов
        int[] array = new int[4];

// Заполняем массив случайными трехзначными числами
        for (int i = 0; i < 4; i++)
        {
// Генерируем случайное трехзначное число
            array[i] = random.Next(100, 1000);
        }

// Выводим массив на экран
        Console.WriteLine("Массив:");
        Console.WriteLine("[" + string.Join(", ", array) + "]");

// Считаем количество четных чисел в массиве
        int countEven = 0;
        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                countEven++;
            }
        }

        Console.WriteLine($"Количество четных чисел в массиве: {countEven}");
    }
}
