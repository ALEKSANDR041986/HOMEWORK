// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координату A X: ");
double ax = double.Parse(Console.ReadLine());
Console.Write("Введите координату A Y: ");
double ay = double.Parse(Console.ReadLine());


Console.Write("Введите координату B X: ");
double bx = double.Parse(Console.ReadLine());
Console.Write("Введите координату B Y: ");
double by = double.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(bx-ax, 2) + Math.Pow(by-ay, 2));

Console.WriteLine($"Дистанция между 2 точек: {distance}");