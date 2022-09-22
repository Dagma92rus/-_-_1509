// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек
// и находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


// Math.Pow(2, 10);
// double num = Math.Sqrt(10); 
// // 5,09986564 - 5,09
// double res = Math.Round(num, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(res);

Console.WriteLine("Введите координаты  первой точки X: ");
Console.Write("X1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты  первой точки X: ");
Console.Write("X2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance(int argX1,int argY1,int argX2,int argY2)
{
    double res = Math.Sqrt(Math.Pow((argX1-argX2), 2)+Math.Pow((argY1-argY2), 2));
    return res;
}
double distance = Distance(x1,y1,x2,y2);
Console.WriteLine(Math.Round(distance, 2, MidpointRounding.ToZero));
