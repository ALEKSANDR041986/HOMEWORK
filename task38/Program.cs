// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//-------- Инициализация

double min = 1;
double max = 100;
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
double[] array = CreateArray(size, min, max);

// //----------работа
PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным  элементов массива составляет {DiffArr(array)}.");

//----------Создаем массив
double[] CreateArray(int size, double min, double max)
{
    double[] res = new double[size];
    for (double i = 0; i < size; i++)
    {
        res[i] = new Random().Next(min,max);
    }
    return res;
}

//--------Печать массива
void PrintArray(double[] SomeArray)
{
    Console.Write("[");
    for (int i = 0; i < SomeArray.Length - 1; i++)
    {
        Console.Write($"{SomeArray[i]}, ");
    }
    Console.Write($"{SomeArray[SomeArray.Length - 1]}] -->>");
}

//------------разница в массиве
double DiffArr(double[] SomeArray)
{
    double maxnum = SomeArray[0];
    double minnum = SomeArray[0];
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
    double diff;
    return maxnum;
    return minnum;
    diff = maxnum - minnum;

}

// //----------работа
// PrintArray(array);
// Console.WriteLine($"Разница между максимальным  и минимальным   элементов массива составляет {DiffArr(array)}.");


