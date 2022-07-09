// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] ArrayFill(int[] array, int min, int max)
{
    //Метод заполнения массива любой размерности рандомными числами от min до max
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++) array[i] = rand.Next(min, max);
    return array;
}

void ArrayPrint(int[] array)
{
    //Метод вывода массива на экран
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(", ");
    }
    Console.Write("]\n");
}

int ArrayOddPosSum(int[] array)
{
    int sum = 0;
    for (int index = 0; index < array.Length; index++)
        if (index % 2 != 0) sum += array[index];
    return sum;
}

int[] array = new int[10];

ArrayFill(array, 0, 10);
ArrayPrint(array);
Console.WriteLine($"Сумма элементов на чётных позициях: {ArrayOddPosSum(array)}");