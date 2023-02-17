// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

//-------- Инициализация

int min = 1;
int max = 100;
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
double[] array = CreateArray(size, min, max);

// //----------работа
PrintArray(array);
Console.WriteLine($"Разница между максимальным и минимальным  элементов массива составляет {DiffArr(array)}.");

//----------Создаем массив
double[] CreateArray(int siz, int minValue, int maxValue)
{
    double[] res = new double[siz];
    for (int i = 0; i < siz; i++)
    {
        res[i] = new Random().NextDouble() * 10 + new Random().Next(minValue, maxValue);
        // }            new Random().NextDouble() * 10 + new Random().Next(minValue, maxValue)  
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
    double diff = 0;
    double maxnum = SomeArray[0];
    double minnum = SomeArray[0];
    for (int i = 0; i < SomeArray.Length; i++)
    {
        if (SomeArray[i] > maxnum)
        {
            maxnum = SomeArray[i];
        }
        else if (SomeArray[i] < minnum)
        {
            minnum = SomeArray[i];
        }
        diff = maxnum - minnum;
    }
    return diff;
}








// //----------работа
// PrintArray(array);
// Console.WriteLine($"Разница между максимальным  и минимальным   элементов массива составляет {DiffArr(array)}.");


