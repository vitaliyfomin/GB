using System;
Console.Clear();

Console.Write($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 100 && number < 999)

{
    int secondDigit = (number  / 10 % 10);
    Console.WriteLine($"Вторая цифра числа: " + secondDigit);
}

else

{
    Console.WriteLine($"Вы ввели не верные цифры");
}

