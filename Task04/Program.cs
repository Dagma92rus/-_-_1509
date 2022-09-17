// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("введите а:");
int a = Convert.ToInt32(Console.ReadLine());// Запрашиваем I число
Console.WriteLine("введите b:");
int b = Convert.ToInt32(Console.ReadLine());// Запрашиваем II число
if (a > b) Console.WriteLine($"Первое число a = {a} большее");
else Console.WriteLine($"Второе число b = {b} большее");