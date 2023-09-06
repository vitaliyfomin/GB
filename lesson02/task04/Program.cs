using System;
Console.Clear();
Console.Write("Введите первое число: ");
double numb1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double numb2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье число: ");
double numb3 = Convert.ToDouble(Console.ReadLine());

double max = Math.Max(numb1, Math.Max(numb2, numb3));

Console.WriteLine($"Максимальное число: {max}");