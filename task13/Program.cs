// Задача 13: Напишите программу, которая 
// 1. выводит третью цифру заданного числа или
// 2. сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit(int number)
{
    while (number >= 1000)
    {
        number = number / 10;
    }

    return number % 10;
}

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine($"Третьей цифры в числе нет");
    return -1;
}
int result = ThirdDigit(number);
Console.WriteLine($"Третья цифра числа {number} ==> {result}");

return 1;



