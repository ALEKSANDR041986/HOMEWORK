// Напишите программу, которая по 
// заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой 
// четверти (x и y).

Console.WriteLine("Введите номер четверти");
int QUA = int.Parse(Console.ReadLine());

if (QUA==1)
{
    Console.WriteLine("X>0,Y>0");
}
else if (QUA==2)
{
    Console.WriteLine("X<0,Y>0");
}
else if (QUA==3)
{
    Console.WriteLine("X<0,Y<0");
}
else if (QUA==4)
{
    Console.WriteLine("X>0,Y<0");
}
else 

{
    Console.WriteLine("ошибка");
}
