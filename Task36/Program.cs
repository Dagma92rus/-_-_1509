// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// шаг 1: Задать одномерный массив со случайными числами
int[] rndNumArray = CreateArrayRndInt(4, -99, 99);
PrintArray(rndNumArray);
// шаг 2: Найти сумму элементов на нечётных позициях
int sumNumEven = SumNumEven(rndNumArray);
System.Console.WriteLine("Сумма элементов массива, стоящих на нечётных позициях равна -> " + sumNumEven);

// метод создания массива
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
// метод печати 
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
// метод суммирования элементов массива на нечётных позициях
int SumNumEven(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((i+1) % 2 != 0) sum = sum + array[i];
    }
    return sum;
}