// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int min, int max)
{
    if (min >= max) return min;
    else return min + Sum(min + 1, max);
}

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {Sum(m, n)}");