using System;

class Program
{
    static void Main()
    {
// Очищаем терминал перед началом выполнения программы
        Console.Clear();

        Console.Write("Введите значение k1: ");
        double k1 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение b1: ");
        double b1 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение k2: ");
        double k2 = double.Parse(Console.ReadLine());

        Console.Write("Введите значение b2: ");
        double b2 = double.Parse(Console.ReadLine());

// Решаем систему уравнений
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;


        Console.WriteLine($"Точка пересечения прямых: ({x}; {y})");
    }
}
