// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//  Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите N");
int N = int.Parse(Console.ReadLine());
NaturalNums(N);

void NaturalNums(int N, int finish=1)
{
    Console.Write($"{N}");
    if (N == finish)
    {
        Console.Write(".");
    }
    else
    {
        Console.Write(",");
        NaturalNums(N-1,finish );
    }
}

