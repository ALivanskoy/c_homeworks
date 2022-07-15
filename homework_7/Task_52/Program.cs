// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[,] ArrayFill(double[,] array, double min, double max)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(rand.NextDouble() * (max - min) + min, 0);
        }

    return array;
}

double ArrayAverage(double[,] array, int column)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        sum += array[i, column];
    return Math.Round(sum / array.GetLength(0), 1);
}

double[,] array = new double[3, 4];
ArrayFill(array, 0, 9);

Console.Write("Среднее арифметическое каждого столбца: ");
for (int i = 0; i < array.GetLength(1); i++)
{
    Console.Write($"{ArrayAverage(array, i)}");
    if (i < array.GetLength(1) - 1) Console.Write("; ");
}