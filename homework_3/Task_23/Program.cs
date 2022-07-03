// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
void Line(char inSym, int length)
{
    for (int i = 0; i <= length; i++) Console.Write(inSym);
    Console.Write("\n");
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Num:\t Сube:");
Line('-',14);
for (int i = 0; i <= num; i++)
{
    Console.WriteLine($"{i} \t  {Math.Pow(i, 3),5}");
    Line('-',14);
}

