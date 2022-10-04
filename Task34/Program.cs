// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// шаг 1: создать массив из случайных положительных трёхзначных чисел
int sizeArray = 4, minNum = 100, maxNum = 1000;
int[] newArray = CreateArrayRndInt(sizeArray, minNum, maxNum);
PrintArray(newArray);
// шаг 2: посчитать количество чётных чисел в получившемся массиве
int oddNumber = OddNumber(newArray);
System.Console.WriteLine("В новом сгенерированном массиве количество чётных чисел равно -> " + oddNumber);

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
// метод подсчёта чётных чисел
int OddNumber(int[] array)
{
    int current = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) current++;
    }
    return current;
}
