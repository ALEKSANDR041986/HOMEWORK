// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("введите число N ");
int N = int.Parse(Console.ReadLine());
int x=0;
Console.Write($"{N}->");
if (N>0)
{
while (x<N)
{
Console.Write(Math.Pow(x,3)+", ");
x++;
}
}
else
while (x>N)
{
Console.Write(Math.Pow(x,3)+", ");
x--;
}
Console.Write(Math.Pow(N,3));
