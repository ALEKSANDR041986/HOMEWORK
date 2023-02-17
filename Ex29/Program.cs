
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


int Prompt(string message)
{
    System.Console.WriteLine(message); // приводим приглашение ко вводу
    string readinput = System.Console.ReadLine();
    int result = int.Parse(readinput); // приводим к числу
    return result;
}
// метод для определения случайных чисел массива
int[] GenerateArray(int Length, int minValue, int maxValue)
{
    int[] array = new int[Length];   //объявляем массив
    Random random = new Random();
    for (int i = 0; i < Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1); //заполняем случайными цифрами
    }
    return array;
}
void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, "); //вывод значения массива
    }
    System.Console.Write($"{array[array.Length - 1]}"); //вывод значения массива
    System.Console.WriteLine("]");
}
int size = Prompt("Длина массива ");
int min = Prompt("введите минимальное значение ");
int max = Prompt("введите максимальное значение ");
int []array = GenerateArray(size, min,max); //заполнение массива случайными числами 
PrintArray(array); //вывод массива