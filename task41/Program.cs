// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Сколько чисел хотите ввести? ");
// int M=int.Parse(Console.ReadLine());

// int num = M*AskNumber("");


// int AskNumber (string msg)
// {
// int i=0;
// while (i<M)
// {
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine());
// }
// i++;
// return i;
// }




//-------
int m = AskNumber("Введите количество элементов: ");
int[] array = GetArray(m, -100, 100);
PrintArray(array);
int a = CountNums(array);
Console.WriteLine($" ---> Количество нечетных элементов:{a}");

//------------
int AskNumber(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

//-------------
int[] GetArray(int siz, int min, int max)
{
    int[] res = new int[siz];
    for (int i = 0; i < siz; i++)
    {
        res[i] = int.Parse(Console.ReadLine());
    }
    return res;
    Console.WriteLine($"{res}");
}

//-------------
void PrintArray(int[] newArray)
{
    Console.Write("[");
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"{newArray[i]} ");
    }
    Console.Write("]");
    
}

//-------------
int CountNums(int[] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] < 0)
        {
            count = count + 1;
        }
    }
    return count;
}

