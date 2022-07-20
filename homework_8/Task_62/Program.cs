// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void ArrayPrint(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] ArraySpiralFill(int number)
{
    int[,] array =
    {
        { number*1, number * 2, number * 3, number * 4},
        { number*12, number * 13, number * 14, number * 5},
        { number*11, number * 16, number * 15, number * 6},
        { number*10, number * 9, number * 8, number * 7}

    };
    return array;
}
int[,] array = new int[4, 4];
array = ArraySpiralFill(1);
ArrayPrint(array);