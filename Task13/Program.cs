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

if (number < 100)
{
    if (number > 100 && number < 1000)
    {
        Digit = number - (number / 10) * 10;
        Console.WriteLine($"Третья цифра от числа {number} является {Digit}.");
    }

    else
    {
        while (number > 999)
        {
            number = number / 10;
            Digit = number - (number / 10) * 10;
        }
        Console.WriteLine($"Третья цифра от числа {number} является {Digit}.");

    }
    

}

else
{
    Console.WriteLine("Число не является трехзначным, третьей цифры нет!");
}