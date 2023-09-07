using System;
Console.Clear();

Console.Write($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 100)

{
    int thirdDigit = (number  / 100) % 10;
    Console.WriteLine($"Треть цифра числа: " + thirdDigit);
}

else

{
    Console.WriteLine($"Вы ввели не менее трех цифр!");
}

