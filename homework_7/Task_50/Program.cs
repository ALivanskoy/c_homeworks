// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

int[,] ArrayFill(int[,] array, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(min, max);
        }

    return array;
}

int[,] array = new int[4, 3];

ArrayFill(array, 0, 10);

Console.Write("Введите строку искомого элемента: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец искомого элемента: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > array.GetLength(0) || n > array.GetLength(1)) Console.Write("такого числа в массиве нет");
else Console.Write($"Элемент на позиции {m},{n} = {array[m - 1, n - 1]}");