// Задача 10: Напишите программу, которая 
// 1. принимает на вход трёхзначное число и на выходе 
// 2. показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите число из диапазона 100 - 999: ");
int number = Convert.ToInt32(Console.ReadLine());

void secondDigit(int num)
{
    if (num >= 100 && num < 1000)
    {
        int temp1 = num / 10;
        int temp2 = temp1 % 10;
    Console.WriteLine($"Вторая цифра числа {num} --> {temp2}");
    }
    else
        Console.WriteLine("Введённое число не соответствует диапазону ввода, повторите попытку ");
}
secondDigit(number);
