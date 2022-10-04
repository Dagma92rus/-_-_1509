// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// шаг 1: Задать массив ВЕЩЕСТВЕННЫХ чисел (0.0)
double[] rndNumArray = CreateArrayRndDoub(4, -99, 99);
PrintArray(rndNumArray);
// шаг 2: Найти разницу между макс. и мин. элементами массива
double quotientMinMaxNumArr = QuotientMinMaxNumArr(rndNumArray);
System.Console.WriteLine("Частное между максимальным и минимальным элементами массива равно -> " + quotientMinMaxNumArr);

// метод создания массива
double[] CreateArrayRndDoub(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() + Convert.ToDouble(rnd.Next(min - 1, max)), 1);

    }
    return array;
}
// метод печати 
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
// метод нахождения частного между минимальным и максимальным элементом массива
double QuotientMinMaxNumArr(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    return max - min;
}
