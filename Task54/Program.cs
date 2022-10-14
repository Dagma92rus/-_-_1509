// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// шаг 1: создаём матрицу с размерностью 3х4 со значениями от 1 до 9
int[,] matrixCurrent = CreateMatrix
(
    rows: 3,
    columns: 4,
    min: 1,
    max: 9
);
PrintMatrix(matrixCurrent);
System.Console.WriteLine();
// шаг 2: упорядочиваем каждый элемент строки от большего к меньшему
MatrixSortRowsMaxToMin(matrixCurrent);
PrintMatrix(matrixCurrent);

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
// метод сортировки элементов строк матрицы от большего к меньшему
void MatrixSortRowsMaxToMin(int[,] matrix)
{
    int[] arrayTemp = new int[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           arrayTemp[j] = matrix[i, j];
        }
        Array.Sort(arrayTemp);
        Array.Reverse(arrayTemp);
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
           matrix[i, n] = arrayTemp[n];
        }
    }
}
