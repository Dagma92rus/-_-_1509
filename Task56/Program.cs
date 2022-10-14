// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой 
// элементов: 1 строка

// шаг 1: создаём матрицу с размерностью 3х4 со значениями от 1 до 9
int[,] matrixCurrent = CreateMatrix
(
    rows: 4,
    columns: 4,
    min: 1,
    max: 9
);
PrintMatrix(matrixCurrent);
System.Console.WriteLine();
// шаг 2: находим сумму элементов каждой строки матрицы
int[] sumElemFromMatrix = GetSumElementsRows(matrixCurrent);
PrintArray(sumElemFromMatrix);
// шаг 3: находим строку с наименьшей суммой, выводим номер этой строки
int indexMinSumRow = IndexMinNum(sumElemFromMatrix);
System.Console.WriteLine($"Наименьшая сумма находится в -> {indexMinSumRow + 1} строке");


// метод создания двумерного массива
int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)  //rows (0)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) //columns (1)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
// метод печати матрицы 
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j],8}");
        }
        System.Console.WriteLine();
    }
}
// метод вычисления суммы элементов для каждой строки
int[] GetSumElementsRows(int[,] matrix)
{
    int[] arr = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        arr[i] = sum;
    }
    return arr;
}
// метод печати одномерного массива
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
// метод нахождения индекса минимального элемента массива
int IndexMinNum(int[] arr)
{
    int min = arr[0];
    int indexMin = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            indexMin = i;
        }
    }
    return indexMin;
}