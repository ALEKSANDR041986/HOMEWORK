// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// --------------------
Console.WriteLine("Введите количество строк");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите min элемент");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите max элемент");
int max = int.Parse(Console.ReadLine());

// --------------
int[,] newArray = GetArray(rows, columns, min, max);
PrintArray(newArray);
Console.WriteLine($"Строка с наименьшей суммой {minSumArray(newArray)}");


// -------------
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

// -------------
void PrintArray(int[,] Arr)
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            Console.Write($"{Arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// -----------------
int minSumArray(int[,] arraySum)
{
    int row = 0;
    int minSum = 0;
    for (int i = 0; i < arraySum.GetLength(1); i++)
    {
        minSum += arraySum[0, i];
    }
    for (int k = 1; k < arraySum.GetLength(0); k++)
    {
        int sum = 0;
        for (int j = 0; j < arraySum.GetLength(1); j++)
        {
            sum = sum + arraySum[k, j];
        }
        if (minSum > sum)
        {
            minSum = sum;
            row = k;
        }
    }
    return row;
}