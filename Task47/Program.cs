// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5      7       -2      -0,2
// 1        -3,3    8       -9,9
// 8        7,8     -7,1    9

// шаг 1: задаём двумерный массив 
double[,] realNumMatrix = new double[3, 4];
// шаг 2: заполняем массив вещественными числами
RealNumMatrix(realNumMatrix, -9, 9);
// шаг 3: печатаем массив
PrintMatrix(realNumMatrix);

// метод создания и заполнения двумерного массива вещественными числами
void RealNumMatrix(double[,] matrix, int min, int max)
{   
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.Next(min - 1, max) + rnd.NextDouble(), 1);
        }
    }
}
// метод печати массива 
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j], 6}");
        }
        System.Console.WriteLine();
    }
}

