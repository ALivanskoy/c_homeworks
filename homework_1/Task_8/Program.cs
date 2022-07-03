// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int num = 0;

Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

if (num > 1)
{
    for (int i = 1; i <= num; i++)
        if (i % 2 == 0) Console.Write($"{i} ");
}
else Console.Write("Поставленная задача не имеет решений");