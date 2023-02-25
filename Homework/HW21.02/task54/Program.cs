// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

Console.WriteLine();

sortArray(newArray);
PrintArray(newArray);


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



void sortArray(int[,] arraySort)
{
    for (int i = 0; i < arraySort.GetLength(0); i++)
    {
        for (int j = 0; j < arraySort.GetLength(1); j++)
        {
            for (int k = 0; k < arraySort.GetLength(1) - 1; k++)
            {
                if (arraySort[i, k+1] > arraySort[i, k])
                {
                    int temp = arraySort[i, k+1];
                    arraySort[i, k+1] = arraySort[i, k];
                    arraySort[i, k] = temp;
                }
            }
        }
    }
}

