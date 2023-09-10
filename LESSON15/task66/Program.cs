using System;

class Program
{
    static void Main()
    {
        Console.Clear();

        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        int sum = GetSumOfNaturalNumbersInRange(M, N);
        Console.WriteLine($"Сумма натуральных чисел от {M} до {N}: {sum}");
    }

    static int GetSumOfNaturalNumbersInRange(int M, int N)
    {
        if (M <= 0 || N <= 0)
        {
            // Возвращаем 0, если M или N не являются натуральными числами
            return 0;
        }

        int sum = 0;
        for (int i = M; i <= N; i++)
        {
            sum += i;
        }
        return sum;
    }
}
