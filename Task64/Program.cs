// Home Work 9
// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int numN = 5;
RangeOneToInputNumber(numN);

void RangeOneToInputNumber(int num)
{
    if (num == 0) return;
    if (num > 1) System.Console.Write(num + ", ");
    else System.Console.Write(num);

    RangeOneToInputNumber(num - 1);
}