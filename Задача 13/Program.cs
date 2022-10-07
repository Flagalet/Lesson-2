// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
if (a < 100)
{
    Console.WriteLine($"У числа {a} нет третьей цифры");
}
if (a <= 1000 && a > 99 ) 
{
    int b = (a % 10);
    Console.WriteLine($"Третья цифра числа {a} -> {b}");
}
if (a > 9999)
{
    int b = (a / 100) % 10;
    Console.WriteLine($"Третья цифра числа {a} -> {b}");
}

    



