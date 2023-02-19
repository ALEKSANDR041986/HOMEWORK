// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 

// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// [1,7] -> по такому индексу нет элемента.


//-------------
// -------------
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());
int m = new Random().Next(1, 10);
int n = new Random().Next(1, 10);
Console.WriteLine($"Координаты: [{m},{n}]");                         // координаты

// ------------
int[,] array = GetArray(rows, columns, 1, 10);
PrintArray(array);
FindArr(array,m,n);


//---------------
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

// -----------
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindArr(int [,] newArray,int m,int n)
{
if (m<=rows && n<=columns)
{
    Console.WriteLine($"Возвращаемое значение : {newArray[m,n]}");
}
else 
{
    Console.WriteLine("Такого элемента не существует");
}
}
