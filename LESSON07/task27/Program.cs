using System;

class Program
{
    static void Main()
    {
        Console.Clear();

        Console.Write("Введите число: ");
        string input = Console.ReadLine();

        int sum = CalculateDigitSum(input);

        Console.WriteLine($"Сумма цифр в числе {input} равна {sum}");
    }

    static int CalculateDigitSum(string number)
    {
        int sum = 0;

        foreach (char digit in number)
        {
            if (char.IsDigit(digit))
            {
                sum += int.Parse(digit.ToString());
            }
        }

        return sum;
    }
}
