﻿// Задача 15: Напишите программу, которая
// 1. принимает на вход цифру, обозначающую день недели, 
// 2.и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

// if (num == 6 || num == 7)
// {
//     Console.WriteLine("Это выходной день");
// }
// else
// Console.WriteLine("Этот день не является выходным");


if (num == 1)
{
    Console.WriteLine("Понедельник - рабочий день");
}
else if (num == 2)
{
    Console.WriteLine("Вторник - рабочий день");
}
else if (num == 3)
{
    Console.WriteLine("Среда - рабочий день");
}
else if (num == 4)
{
    Console.WriteLine("Четверг - рабочий день");
}
else if (num == 5)
{
    Console.WriteLine("Пятница - рабочий день");
}
else if (num == 6)
{
    Console.WriteLine("Суббота - выходной день");
}
else if (num == 7)
{
    Console.WriteLine("Воскресение - выходной день");
}
else
{
    Console.Write("Ошибочный ввод данных");
}