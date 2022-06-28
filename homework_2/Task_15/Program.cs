﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число, соответсвующее дню недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0 && num < 6) Console.Write($"{num}-ый день недели не выходной");
else if (num == 6 || num == 7) Console.Write($"{num}-ой день недели выходной");
else Console.Write($"Введённое число не соответствует дню недели");