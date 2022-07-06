// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int NumberSum(int inputNum)
{
    int sum = 0;
    inputNum = Math.Abs(inputNum);
    while (inputNum > 10)
    {
        sum += inputNum % 10;
        inputNum /= 10;
    }
    sum += inputNum;
    return sum;
}

Console.Write($"Введите число, в котором будем искать сумму цифр: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {number} равна {NumberSum(number)}");