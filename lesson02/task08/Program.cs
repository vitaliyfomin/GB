using System;
Console.Clear();

Console.Write($"Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Чeтные числа от 1 до " + N + ":");

for (int i = 2; i <= N; i += 2)
{
Console.Write(i + $" ");
}
