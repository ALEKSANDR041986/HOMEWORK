// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
int[,] matrixA = GetArray(rows, columns, min, max);
PrintArray(matrixA);
Console.WriteLine();
int[,] matrixB = GetArray(rows, columns, min, max);
PrintArray(matrixB);
// MatrixMult(matrixA,matrixB);

Console.WriteLine($"Результирующая матрица будет: {MatrixMult(matrixA,matrixB)}");

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

int[,] MatrixMult(int[,] matrixA, int[,] matrixB)
{
    int rowsA = matrixA.GetLength(0);
    int columnsB = matrixB.GetLength(1);
    int[,] result = new int[rowsA, columnsB];
    if (matrixA.GetLength(0) == matrixB.GetLength(1))
    {
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < columnsB; j++)
            {
                for (int n = 0; n < matrixA.GetLength(1); n++)
                {
                    result[i, j] += matrixA[i, n] * matrixB[n, j];
                }
            }

        }
    }
    return result;
}