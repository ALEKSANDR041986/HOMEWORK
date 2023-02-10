// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int Prompt(string message)
{
    System.Console.WriteLine(message); //выводим приглашение ко вводу
    string readinput = System.Console.ReadLine();
    int result = int.Parse(readinput); // приводим к числу
    return result; //возвращаем результат
}
int SummAllDigit(int number)
{
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}
int number=Prompt("введите число ");
System.Console.WriteLine($"сумма всех чисел в цифре {number}={SummAllDigit(number)}");