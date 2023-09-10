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

        Console.WriteLine(GetNaturalNumbersInRange(M, N));
    }

    static string GetNaturalNumbersInRange(int M, int N)
    {
        if (M <= 0 || N <= 0)
        {
            return "Введены некорректные значения. M и N должны быть натуральными числами.";
        }

        string result = "";
        for (int i = M; i <= N; i++)
        {
            result += i.ToString();
            if (i < N)
            {
                result += ", ";
            }
        }
        return $"\"{result}\"";
    }
}
