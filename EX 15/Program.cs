// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
int day = new Random().Next(1,8);
if(day<6)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{day}->НЕТ");
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"{day}->ДА");
}
