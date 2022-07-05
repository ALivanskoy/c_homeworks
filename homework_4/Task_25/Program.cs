// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Pow(double number, double degree)
{
    double ans = number;
    double count_degree;
    for (count_degree = 1; count_degree < degree; count_degree++)
    {
        try
        {
            checked
            {
                ans *= number;
            }
        }
        catch (System.OverflowException)
        {
            Console.WriteLine($"Ошибка переполнения типов данных. Последняя удачно обработанная операция: {number} ^ {count_degree} = {ans}");
            break;
        }
    }

    return ans;
}