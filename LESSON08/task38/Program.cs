using System;

class Program
{
    static void Main()
    {
// Очистка терминала
        Console.Clear();
// Создаем массив вещественных чисел
        double[] array = { 3, 7, 22, 2, 78 };

// Находим минимальный и максимальный элементы в массиве
        double min = array[0];
        double max = array[0];

        foreach (double number in array)
        {
            if (number < min)
            {
                min = number;
            }

            if (number > max)
            {
                max = number;
            }
        }

// Находим разницу между максимальным и минимальным элементами
        double difference = max - min;

        Console.WriteLine($"Минимальный элемент: {min}");
        Console.WriteLine($"Максимальный элемент: {max}");
        Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
    }
}
