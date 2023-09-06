using System;
Console.Clear();

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

int max;
if (a > b)
{
    max = a;
}
if (b > c)
{
    max = b;
}
else
{
    max = c;
}

Comsole.WriteLine($"Максимальное число: {max}");
