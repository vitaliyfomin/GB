using System;

class Program
{
    static void Main()
    {
        Console.Clear();

        Console.Write("Введите число M: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        AkkermanFunction(m, n);

    }

    // вызов функции Аккермана
    static void AkkermanFunction(int m, int n)
    {
        Console.Write($"A(m,n)= {Akkerman(m, n)}");
    }

    // функция Аккермана
    static int Akkerman(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0 && m > 0)
        {
            return Akkerman(m - 1, 1);
        }
        else
        {
            return Akkerman(m - 1, Akkerman(m, n - 1));
        }
    }
}
