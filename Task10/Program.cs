﻿/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трехзначное число ");
int Number = Convert.ToInt32(Console.ReadLine());

int numberOne = Number / 100;
int numberThree = Number - (Number / 10) * 10;

int SecondNumber = ((Number - (numberOne * 100) - numberThree) / 10);

Console.WriteLine($"Число {Number} - оставляем среднюю цифру - {SecondNumber}");
