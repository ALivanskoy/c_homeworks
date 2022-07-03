// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = -1, // Проверяемое число
solution = -1;   // Способ решения

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

bool IsPaliandrom(int inputNum)
{
    // Метод по определению является ли число inputNum палиндромом

    bool isPaliandrom = true;
    for (int i = 1; i <= NumberLength(inputNum) / 2; i++)
    {
        if (WhatDigit(inputNum, i) != WhatDigit(inputNum, -i)) isPaliandrom = false;
    }
    return isPaliandrom;
}

Console.WriteLine("Задача решена для двух случаев: общего и частного.");
Console.WriteLine("1. В частном случае проверяется является ли введённое пятизначное число палиндромом. (Введите 1)");
Console.WriteLine("2. В общем случае проверяется является ли ЛЮБОЕ введённое число палиндромом.(Введите 2)");
Console.WriteLine("Для продолжения введите способ решения: ");

solution = Convert.ToInt32(Console.ReadLine());

if (solution == 1)
{
    Console.WriteLine("Введите пятизначное число: ");
    number = Convert.ToInt32(Console.ReadLine());

    if (number > 9999 && number < 100000)
    {
        if (IsPaliandrom(number)) Console.WriteLine($"Число {number} является палиндромом");
        else Console.WriteLine($"Число {number} не является палиндромом");
    }
    else Console.WriteLine($"Число {number} не пятизначное");
}
else if (solution == 2)
{
    Console.WriteLine("Введите число: ");
    number = Convert.ToInt32(Console.ReadLine());

    if (IsPaliandrom(number)) Console.WriteLine($"Число {number} является палиндромом");
    else Console.WriteLine($"Число {number} не является палиндромом");
}
else Console.WriteLine("Выбран некорректный способ решения");