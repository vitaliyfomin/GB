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

// Заполняем массив случайными числами
        for (int i = 0; i < 4; i++)
        {
// Генерируем случайное число
            array[i] = random.Next(-100, 100);
        }

// Выводим массив на экран
        Console.WriteLine("Массив:");
        Console.WriteLine("[" + string.Join(", ", array) + "]");

// Находим сумму элементов на нечетных позициях
        int sum = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }

        Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");
    }
}
