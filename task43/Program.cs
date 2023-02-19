// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

------

int AskNumber(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

int Crossing(int a, int b, int c, int d)
{
    // int y = c * x + a;
    // int y = d * x + b;
    int y = c * (b - a) / (c - d) + a;
    int x = (b - a) / (c - d);
    return x;
    return y;
    Console.WriteLine($"Точка пересечения:{x},{y}");
}

//---------
int b1 = AskNumber("Введите b1: ");
int b2 = AskNumber("Введите b2: ");
int k1 = AskNumber("Введите k1: ");
int k2 = AskNumber("Введите k2: ");
int ans = Crossing(b1, b2, k1, k2);
Console.WriteLine($"Точка пересечения: ");

