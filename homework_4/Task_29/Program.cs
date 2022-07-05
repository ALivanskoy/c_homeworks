// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]



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
    Console.Write("]");
}

int[] array = new int[8];
array = ArrayFill(array, 0, 9);
ArrayPrint(array);

