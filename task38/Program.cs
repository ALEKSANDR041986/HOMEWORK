// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//-------- Инициализация

int min = 1;
int max = 100;
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = CreateArray(size, min, max);

// //----------работа
// PrintArray(array);
// Console.WriteLine($"Разница между максимальным {maxnum} и минимальным {minnum}  элементов массива составляет {DiffArr(array)}.");

//----------Создаем массив
int[] CreateArray(int size, int min, int max)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min, max + 1);
    }
    return res;
}

//--------Печать массива
void PrintArray(int[] SomeArray)
{
    Console.Write("[");
    for (int i = 0; i < SomeArray.Length - 1; i++)
    {
        Console.Write($"{SomeArray[i]}, ");
    }
    Console.Write($"{SomeArray[SomeArray.Length - 1]}] -->>");
}

//------------разница в массиве
int DiffArr(int[] SomeArray)
{
    int maxnum = SomeArray[0];
    int minnum = SomeArray[0];
    for (int i = 1; i < SomeArray.Length-1; i++)
    {
        if (SomeArray[i] > maxnum)
        {
            maxnum = SomeArray[i];
        }
        else
        {
            minnum = SomeArray[i];
        }
    }
    int diff;
    return maxnum;
    return minnum;
    diff = maxnum - minnum;

}

//----------работа
PrintArray(array);
Console.WriteLine($"Разница между максимальным  и минимальным   элементов массива составляет {DiffArr(array)}.");


