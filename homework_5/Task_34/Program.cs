// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int ArrayEvenCount(int[] array)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
        if (array[index] % 2 == 0) count++;
        return count;
}

int[] array = new int[4];

ArrayFill(array, 100, 1000);
ArrayPrint(array);
Console.WriteLine($"Количество чётных чисел в массиве: {ArrayEvenCount(array)}");