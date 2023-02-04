// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("введите пятизначное число ");
int x = int.Parse(Console.ReadLine());
int a1 = x / 10000;
int a2 = x % 10;
int b = x / 1000;
int b1 = b % 10;
int b0 = x % 100;
int b2 = b0 / 10;
if (x < 100000 && x > 9999)
{
    if (a1 == a2 & b1 == b2) Console.WriteLine("ДА");
    else
    {
        Console.WriteLine("НЕТ");
    }
}
else
    Console.WriteLine("Вы ввели НЕ пятизначное число");