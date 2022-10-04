// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите три стороны треугольника > ");
int sideA = Convert.ToInt32(Console.ReadLine());
int sideB = Convert.ToInt32(Console.ReadLine());
int sideC = Convert.ToInt32(Console.ReadLine());
if (CanTraiangleExite(sideA,sideB,sideC)) System.Console.WriteLine("Да, такой треугольник существует");
else System.Console.WriteLine("Несуществующий треугольник");

bool CanTraiangleExite(int side1, int side2, int side3)
{
    return side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side1;
}