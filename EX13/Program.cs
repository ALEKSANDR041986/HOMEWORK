// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();
int num = new Random().Next(1, 1000000);
Console.WriteLine("Заданное число " + num);
if (num > 99 & num < 1000)
{
    Console.WriteLine($"{num}-> {num % 10}");
}
if (num > 999 & num < 10000)
{
    Console.WriteLine($"{num}-> {(num % 100 - num % 10) / 10}");
}
if (num > 9999 & num < 100000)
{
    Console.WriteLine($"{num}-> {(num % 1000 - num % 100) / 100}");
}
if (num > 99999 & num < 1000000)
{
    Console.WriteLine($"{num}-> {(num % 10000 - num % 1000) / 1000}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}