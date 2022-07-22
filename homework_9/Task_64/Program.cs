// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNatural(int num)
{
    if (num <= 0)
    {
        Console.Write("∅");
        return;
    }
    if (num > 1)
    {
        Console.Write($"{num}, ");
        PrintNatural(num - 1);
    }
    else Console.Write($"{num}");

}

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Все натуральные числа в промежутке от N до 1: ");
PrintNatural(n);