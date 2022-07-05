// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int NumberLength(int inputNum)
{
    // Метод по нахождению количества цифр в числе inputNum
    int pointOfNumber = 1; // задаём разряд исходного числа. Разряд числа, не может быть меньше одного
    while (inputNum % Math.Pow(10, pointOfNumber) != inputNum) pointOfNumber++; // ищем разрядность
    return pointOfNumber;
}

int WhatDigit(int inputNum, int inputPosition)
{
    // Метод по нахождению цифры в числе inputNum на позиции inputPosition 
    // В случае, если в метод передать отрицательную позицию, метод найдёт цифру с конца числа.

    inputNum = Math.Abs(inputNum);

    if (NumberLength(inputNum) < Math.Abs(inputPosition)) return -1;

    if (inputPosition > 0)
    {
        while (inputNum > Math.Pow(10, inputPosition)) inputNum = inputNum / 10;
        return inputNum % 10;
    }
    else if (inputPosition < 0)
    {
        inputPosition = Math.Abs(inputPosition);
        if (inputPosition == 1) return inputNum % 10;
        else return
        (inputNum % Convert.ToInt32(Math.Pow(10, inputPosition)) -
        inputNum % Convert.ToInt32(Math.Pow(10, inputPosition - 1))) /
        Convert.ToInt32(Math.Pow(10, inputPosition - 1));
    }
    return -1;
}

Console.Write($"Введите число, в котором будем искать сумму цифр: ");
int number = int.Parse(Console.ReadLine()),
sum = 0;

for (int position = 1; position <= NumberLength(number); position++)
{
    sum += WhatDigit(number, position);
}

Console.WriteLine($"Сумма цифр в числе {number} равна {sum}");
