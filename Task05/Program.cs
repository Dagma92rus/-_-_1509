// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("введите а:");
int a = Convert.ToInt32(Console.ReadLine());// Запрашиваем I число
Console.WriteLine("введите b:");
int b = Convert.ToInt32(Console.ReadLine());// Запрашиваем II число
Console.WriteLine("введите c:");
int c = Convert.ToInt32(Console.ReadLine());// Запрашиваем III число

int max = a; 
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine($"Максимальным числом является {max}");