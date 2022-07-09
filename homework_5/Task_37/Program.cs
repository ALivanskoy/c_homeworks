// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] ArrayStrangeMult(int[] array)
{
    int size = 0;
    if (array.Length % 2 == 0) size = array.Length / 2;
    if (array.Length % 2 != 0) size = array.Length / 2 + 1;
    int[] multArray = new int[size];

    for (int index = 0; index < multArray.Length; index++)
    {
        if (index < multArray.Length - 1) multArray[index] = array[index] * array[array.Length - 1 - index];
        else multArray[index] = array[index];
    }
    return multArray;
}

int[] array = new int[5];

ArrayFill(array, 1, 5);
ArrayPrint(array);
ArrayPrint(ArrayStrangeMult(array));