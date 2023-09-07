using System;
Console.Clear();

Console.WriteLine($"Введите день недели (1 - понедельник, 2 - вторник,.... 7 - воскресенье)");

int dayweek = Convert.ToInt32(Console.ReadLine());

if(dayweek == 6 || dayweek == 7)

{
    Console.WriteLine($"Да, это выходной день.");
} 

else

{
    Console.WriteLine($"Нет, это не выходной день");
}