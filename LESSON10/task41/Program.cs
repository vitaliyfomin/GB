using System;

class Program
{
    static void Main()
    {
// Очищаем терминал перед началом выполнения программы
        Console.Clear();

        Console.Write("Введите числа, разделенные запятыми: ");
// Считываем строку, содержащую числа
        string input = Console.ReadLine();

// Разделяем строку на массив чисел, используя запятые как разделители
        string[] numbers = input.Split(',');

// Инициализируем счетчик чисел больше 0
        int count = 0;

// Перебираем числа в массиве
        foreach (string numStr in numbers)
        {
// Пробуем преобразовать строку в число
            if (double.TryParse(numStr.Trim(), out double num))
            {
                if (num > 0)
                {
// Увеличиваем счетчик, если число больше 0
                    count++;
                }
            }
        }
// Выводим результат
        Console.WriteLine($"Количество чисел больше 0: {count}");
    }
}
