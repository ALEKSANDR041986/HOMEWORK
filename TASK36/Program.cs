// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


//----------- инициализация
int min = 1;
int max = 100;
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] arr = CreateArray(size, min, max);

//----------Включаем методы
PrintArray(arr);
Console.WriteLine($"сумма элементов на нечетных позициях составляет - {SummNum(arr)}");

//-----------Метод создания массива
int[] CreateArray(int size, int min, int max)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++) res[i] = new Random().Next(min, max + 1);
    return res;
}

//-------------Печать массива
void PrintArray(int[] Somearray)
{
    Console.Write("[");
    for (int i = 0; i < Somearray.Length-1; i++)
    {
        Console.Write($"{Somearray[i]}, ");
    }
    Console.WriteLine($"{Somearray[Somearray.Length - 1]}]");
}

//------------сумма элементов на нечетных позициях
int SummNum(int[] Somearray)
{
    int summ = 0;
    for (int i = 0; i < Somearray.Length; i++)
    {
        if (i % 2 != 0) summ += Somearray[i];
    }
    return summ;
}