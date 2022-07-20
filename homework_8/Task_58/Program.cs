// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void ArrayFill(int[,] array, int min, int max)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(min, max);
        }
}

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

int[,] MatrixMux(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] mux = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < mux.GetLength(0); i++)
    {
        for (int j = 0; j < mux.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
            {
                mux[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return mux;
}

int[,] firstMatrix = new int[2, 3];
int[,] secondMatrix = new int[3, 2];
int[,] muxMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];

ArrayFill(firstMatrix, 0, 10);
ArrayFill(secondMatrix, 0, 10);
ArrayPrint(firstMatrix);
Console.WriteLine("");
ArrayPrint(secondMatrix);
Console.WriteLine("");

if (firstMatrix.GetLength(0) == secondMatrix.GetLength(1))
{
    muxMatrix = MatrixMux(firstMatrix, secondMatrix);
    ArrayPrint(muxMatrix);
}
else Console.WriteLine("Матрицы не согласованы");