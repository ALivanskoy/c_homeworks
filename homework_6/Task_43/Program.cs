// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// От себя: 
// Задача решена для уравнения прямой вида ax + by + c = 0, где пользователь может ввести все три константы.
// Методы explicitlySignNumber и ShowLineEquation являются "декоративными" и нужны только для красоты отображения, 
// магия вычислений происходит в методах IntersectionPointX и IntersectionPointY, вычисления взятые за основу лежат в фотографии к ДЗ6 на портале GB.ru


void HandlyFillArray(double[] arr)
{
    // Метод ручного заполнения входного массива arr[]
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите  константу №{i + 1} : ");
        arr[i] = Convert.ToDouble(Console.ReadLine());
    }
}

string explicitlySignNumber(double num)
{
    // Метод, явным образом печатающий знак переданного числа num
    if (num >= 0) return $"+ {num}";
    else return $"- {-num}";
}

void ShowLineEquation(double[] arr)
{
    // Метод, печатающий выражения вида "ax + by + c = 0", подставляя в него правильные знаки
    Console.WriteLine($"{(arr[0])} * x  {explicitlySignNumber(arr[1])} * y {explicitlySignNumber(arr[2])} = 0");
}

double IntersectionPointX(double[] fitstConstants, double[] secondConstants)
{
    // Метод, находящий точку пересечения двух прямых по оси Х
    return (secondConstants[1] * fitstConstants[2] - fitstConstants[1] * secondConstants[2]) /
    (secondConstants[0] * fitstConstants[1] - fitstConstants[0] * secondConstants[1]);
}

double IntersectionPointY(double[] fitstConstants, double[] secondConstants)
{
    // Метод, находящий точку пересечения двух прямых по оси Y
    return (secondConstants[0] * fitstConstants[2] - fitstConstants[0] * secondConstants[2]) /
    (fitstConstants[0] * secondConstants[1] - secondConstants[0] * fitstConstants[1]);
}

Console.Clear();

Console.WriteLine("Общее уравнение прямой имеет вид:");
Console.WriteLine("ax + by + c = 0");
Console.WriteLine();

double[] сonstantsFirstLine = new double[3];
double[] сonstantsSecondLine = new double[3];

Console.WriteLine("Задаём константы для уравнения первой прямой:");
HandlyFillArray(сonstantsFirstLine);
Console.WriteLine("Задаём константы для уравнения второй прямой:");
HandlyFillArray(сonstantsSecondLine);
Console.WriteLine();

Console.WriteLine("Уравнение первой прямой имеет вид:");
ShowLineEquation(сonstantsFirstLine);
Console.WriteLine("Уравнение второй прямой имеет вид:");
ShowLineEquation(сonstantsSecondLine);
Console.WriteLine();

double[] intersectionPoint = new double[2];

if (Math.Round((сonstantsFirstLine[0] / сonstantsFirstLine[1]), 1) == Math.Round((сonstantsSecondLine[0] / сonstantsSecondLine[1]), 1))
    Console.WriteLine("Данные прямые параллельны");
else
{
    intersectionPoint[0] = IntersectionPointX(сonstantsFirstLine, сonstantsSecondLine);
    intersectionPoint[1] = IntersectionPointY(сonstantsFirstLine, сonstantsSecondLine);
    Console.WriteLine($"Точка пересечения прямых х = {intersectionPoint[0]}, y = {intersectionPoint[1]}");
}
