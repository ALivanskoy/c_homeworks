// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] ArrayFill(double[] array, int min, int max)
{
    //Метод заполнения массива любой размерности рандомными числами от min до max
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++) array[i] = Convert.ToDouble(rand.Next(min, max)) + Convert.ToDouble(rand.Next(0, 101)) / 10;
    return array;
}

void ArrayPrint(double[] array)
{
    //Метод вывода массива на экран
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(" / ");
    }
    Console.Write("]\n");
}

double ArrayMinMaxDiff(double[] array)
{
    double
    min = array[0],
    max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
    }

    return Math.Round(max - min,1);
}

double[] array = new double[10];
ArrayFill(array, 0, 10);
ArrayPrint(array);
// Console.WriteLine(array.Max());
// Console.WriteLine(array.Min());
Console.WriteLine($"Разность между максимальным и минимальным эллементом массива: {ArrayMinMaxDiff(array)}");