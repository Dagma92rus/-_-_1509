// Home Work 9
// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// решение 

int numM = 4;
int numN = 8;
if (numM < numN)
{
    int sumFromRange = SumFromRange(numM, numN);
    System.Console.WriteLine(sumFromRange);
}
else System.Console.WriteLine("Введите числа в порядке возрастания");


// методы

    int SumFromRange(int num1, int num2)
    {
        int sum = num2;
        if (num2 > num1) sum += SumFromRange(num1, num2 - 1);
        return sum;
    }
