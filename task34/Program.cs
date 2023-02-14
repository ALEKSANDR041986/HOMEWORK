// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


//-------------
//Инициализация
int min = 100;
int max = 999;
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] arr = Createarray(size, min, max);

//------------
//Работа методов
PrintArray(arr);
Console.Write("Количество четных трехзначных чисел составляет:");
Console.WriteLine($"{CountEvenNumber(arr, 100, 999)}.");

//----------
//Создание массива из 3-значных чисел
int[] Createarray(int length, int min, int max)
{
    int[] res = new int[length];
    for (int i = 0; i < length; i++) res[i] = new Random().Next(min, max + 1);
    return res;
}

//------------
// //Вывод массива на печать
void PrintArray(int[] someArray)
{
    Console.Write("[");
    for (int i = 0; i < someArray.Length - 1; i++)
    {
        Console.Write($"{someArray[i]}, ");
    }
    Console.WriteLine($"{someArray[someArray.Length - 1]}]");
}

int CountEvenNumber (int[] someArray, int down, int up)
{
    int count = 0;
    for (int i = 0; i <= someArray.Length - 1; i++)
    {
        if (someArray [i] % 2  == 0 )
        {
            count++;
        }
    }
    return count;
}