// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
int [] dotA = new int[3];
int [] dotB = new int[3];
var rand = new Random();

for (int i = 0; i < 3; i++)
{
    dotA[i] = rand.Next(-9, 10);
    dotB[i] = rand.Next(-9, 10);
}

Console.WriteLine($"Точка А: x = {dotA[0]} y = {dotA[1]} z = {dotA[2]}");
Console.WriteLine($"Точка B: x = {dotB[0]} y = {dotB[1]} z = {dotB[2]}");

double ans = Math.Sqrt(Convert.ToDouble(Math.Pow((dotA[0]-dotB[0]), 2) + Math.Pow((dotA[1] - dotB[1]),2) + Math.Pow((dotA[2] - dotB[2]),2)));

Console.WriteLine($"ans = {Math.Round(ans, 2)}");

