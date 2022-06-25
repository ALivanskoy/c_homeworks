// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int[] num = new int[3];
int max = 0;

Console.WriteLine("Введите число 1:");
num[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
num[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3:");
num[2] = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < num.Length; i++)
{
    if (max < num[i]) max = num[i];
}

Console.WriteLine($"Максимальное из введёных чисел: {max}");