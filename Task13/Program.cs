/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());
int Digit = 0;
int numberX = number;

if (number > 99)
{
    if (number > 99 && number < 1000)
    {
        Digit = number - (number / 10) * 10;
    }
    else if (number > 999)
    {
        while (number >= 1000)
        {
            number = number / 10;
        }
    }
    Digit = number - (number / 10) * 10;
    Console.WriteLine($"Третья цифра от числа {numberX} является {Digit}.");
}
else
{
    Console.WriteLine("Число не является трехзначным, третьей цифры нет!");
}
