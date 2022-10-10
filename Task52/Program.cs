// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// шаг 1: создаём матрицу с размерностью 3х4 со значениями от 1 до 9
int[,] matrix = CreateMatrix
(
    rows: 3,
    columns: 4,
    min: 1,
    max: 9
);
PrintMatrix(matrix);
System.Console.WriteLine();
// шаг 2: осуществляем поиск среднего арифметического в каждом столбце
double[] average = AverageColumns(matrix);
PrintArray(average);

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
            System.Console.Write($"{matrix[i, j], 8}");
        }
        System.Console.WriteLine();
    }
}
// метод рассчёта среднего арифметического для каждого столбца матрицы
double[] AverageColumns(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix [j, i];
            array[i] = Math.Round(sum / matrix.GetLength(0), 1);
        }
    }
    return array;
}
// метод печати одномерного массива
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write($"[{array[i], 8}");
        else if (i < array.Length) Console.Write($"{array[i], 8}");
    }
    Console.WriteLine("]");
}
