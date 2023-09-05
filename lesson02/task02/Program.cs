using System;
Console.Clear();
Console.Write("Введите первое число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число B: ");
int b = int.Parse(Console.ReadLine());

int max, min;
if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.WriteLine($"Максимальное число: {max}");
Console.WriteLine($"Минимальное число: {min}");