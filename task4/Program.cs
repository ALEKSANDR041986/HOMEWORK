// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Clear();
Console.WriteLine("Введите число");
int N = int.Parse(Console.ReadLine());
int A = N/10;
int X = N - A*10;
Console.WriteLine("Правильный ответ " + X);
