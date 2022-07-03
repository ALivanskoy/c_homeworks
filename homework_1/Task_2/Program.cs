// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int num1, num2;

// Кусок закомментированного кода в строках 11 - 14 выдаёт какую-то околесицу, в то время как код на строках 16 - 19 работает исправно. Не понимаю в чём дело

// Console.WriteLine("Введите первое число: ");
// num1 = Convert.ToInt32(Console.Read());
// Console.WriteLine("Введите второе число: ");
// num2 = Convert.ToInt32(Console.Read());

Console.WriteLine("Введите число 1:");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
    Console.Write($"{num1} > {num2}");
else if (num2 > num1)
    Console.Write($"{num1} < {num2}");
else if (num2 == num1)
    Console.Write($"{num2} = {num1}");
else
    Console.Write("Произошла какая-то ошибка ");