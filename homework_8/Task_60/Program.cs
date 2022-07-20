// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void ArrayFill(int[,,] array, int min, int max)
{
    Random rand = new Random();
    int number = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2);)
            {
                number = rand.Next(min, max);
                if (!CheckNumber(array, number))
                {
                    array[i, j, k] = number;
                    k++;
                }
            }
}

void ArrayPrint(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            {
            for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
                }
                Console.WriteLine();
            }

}

bool CheckNumber(int[,,] array, int number)
{

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
                if (array[i, j, k] == number) return true;
    return false;
}

int[,,] array = new int[2, 2, 2];
ArrayFill(array, 1, 10);
ArrayPrint(array);