using System;

class Program
{
    static void Main()
    {
        Console.Clear(); // Очистка терминала

        Console.Write("Введите число A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Введите степень B: ");
        int B = int.Parse(Console.ReadLine());

        int result = CalculatePower(A, B);
        Console.WriteLine($"{A}^{B} = {result}");
    }

    static int CalculatePower(int A, int B)
    {
        int result = 1;

        for (int i = 1; i <= B; i++)
        {
            result *= A;
        }

        return result;
    }
}
