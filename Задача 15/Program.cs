// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine()!);
if (a == 1 && a <6)
{
    Console.WriteLine("Понедельник выходной? Нет");
}
else if (a == 2 && a <6)
{
    Console.WriteLine("Вторник выходной? Нет");
}
else if (a == 3 && a <6)
{
    Console.WriteLine("Среда выходной? Нет");
}
else if (a == 4 && a <6)
{
    Console.WriteLine("Четверг выходной? Нет");
}
else if (a == 5 && a <6)
{
    Console.WriteLine("Пятница выходной? Нет");
}
else if (a == 6 )
{
    Console.WriteLine("Суббота выходной? Да");
}
else if (a == 7)
{
    Console.WriteLine("Воскресение выходной? Да");
}