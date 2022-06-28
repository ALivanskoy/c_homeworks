// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void magic(int inputNum)
{

    int pointOfNumber = 1; // задаём разряд исходного числа. Разряд числа, не может быть меньше одного


    while (inputNum % Math.Pow(10, pointOfNumber) != inputNum) pointOfNumber++; // ищем разрядность, сравнивая остаток от деления числа на десятку с возрастающей разрядностью с самим числом.
                                                                                // как только числа совпали - мы нашли нашу разрядность


    // проверяем разрядность и если она больше трёх - вычисляем третье число;
    if (pointOfNumber < 3)
    {
        Console.WriteLine("Введённое число не имеет третьей цифры");
    }
    else
    {
        Console.WriteLine(Math.Abs((inputNum % Math.Pow(10, pointOfNumber - 2) - inputNum % Math.Pow(10, pointOfNumber - 3)) / Math.Pow(10, pointOfNumber - 3)));
    }
    // inputNum%Math.Pow(10, pointOfNumber-2) возвращает число, с "обрезанными" первыми двумя разрядами
    // inputNum%Math.Pow(10, pointOfNumber-3) возвращает число, с "обрезанными" первыми тремя разрядами
    // Выражение (inputNum%Math.Pow(10, pointOfNumber-2) - inputNum%Math.Pow(10, pointOfNumber-3))/Math.Pow(10, pointOfNumber-3)
    // вычитает из результата первого выражения результат второго и делением убирает "нижестоящие" разряды числа
    // Модулем отсекается минус в случае, если первоначально число отрицательное
}

magic(num);