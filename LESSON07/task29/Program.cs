using System;

class Program
{
    static void Main()
    {
        Console.Clear();
// Создаем массив из 8 элементов
        int[] array = new int[8];

// Заполняем массив элементами
        for (int i = 0; i < 8; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
// Выводим массив на экран
        Console.WriteLine("Массив:");
        Console.Write("[");
        for (int i = 0; i < 8; i++)
        {
            Console.Write(array[i]);
            if (i < 7)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}
