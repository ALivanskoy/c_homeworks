// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int PositiveNumberCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] > 0) count++;
    return count;
}

void HandlyFillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите число № {i + 1} : ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}



try // конструкция try-catch отлавливает ошибку, если пользователь введёт что-то кроме положительного числа
{
    checked
    {
        Console.Write("Введите количество вводимых чисел: ");
        int mNumbers = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[mNumbers];

        if (mNumbers == 0) Console.WriteLine("Ошибка ввода");
        else
        {
            Console.WriteLine("Введите числа, которые будут проверяться на положительность.");

            HandlyFillArray(array);
            int positiveNumbers = PositiveNumberCount(array);

            Console.Write($"Количество положительных чисел среди введённых: {positiveNumbers}");
        }
    }
}
catch (Exception)
{
    Console.WriteLine("Ошибка ввода");
}



