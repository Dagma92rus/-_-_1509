// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.Write("Введите координаты первой точки Xa > ");
double xa = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты первой точки Ya > ");
double ya = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты первой точки Za > ");
double za = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите координаты первой точки Xb > ");
double xb = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты первой точки Yb > ");
double yb = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координаты первой точки Zb > ");
double zb = Convert.ToInt32(Console.ReadLine());

double Hypotenuse(double argXa, double argYa, double argZa,double argXb, double argYb, double argZb)
{
    double result = Math.Sqrt(Math.Pow((argXa-argXb),2)+Math.Pow((argYa-argYb),2)+Math.Pow((argZa-argZb),2));
    return result; 
}
System.Console.WriteLine(Math.Round(Hypotenuse(xa,ya,za,xb,yb,zb),2));
