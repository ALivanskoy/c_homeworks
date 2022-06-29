﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100) Console.WriteLine("Введённое число не имеет третьей цифры");
else
{
    while (num > 1000) num = num / 10;
    Console.WriteLine($"Третья цифра введённого числа {num % 10}");
}