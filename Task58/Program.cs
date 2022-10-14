// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrixFirst = {{2, 4}, {3, 2}};
PrintMatrix(matrixFirst);
System.Console.WriteLine();
int[,] matrixSecond = {{3, 4}, {3, 3}};
PrintMatrix(matrixSecond);
System.Console.WriteLine();
int[,] resultMultiplyMatrix = MultiplyTwoMatrix(matrixFirst, matrixSecond);
System.Console.WriteLine("Результирующая матрица -> ");
System.Console.WriteLine();
PrintMatrix(resultMultiplyMatrix);

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
// метод перемножения двух матриц
int[,] MultiplyTwoMatrix(int[,] matrFirst, int[,] matrSecond)
{
    int[,] resultMatrix = new int[matrFirst.GetLength(0), matrSecond.GetLength(1)];
    for (int i = 0; i < matrFirst.GetLength(0); i++)
    {
        for (int j = 0; j < matrSecond.GetLength(1); j++)
        {
            int sum = 0;
            for (int n = 0; n < matrSecond.GetLength(1); n++)
            {
                resultMatrix[i, j] = matrFirst[i, n] * matrSecond[n, j];
                sum += resultMatrix[i, j];
            }
            resultMatrix[i, j] = sum; 
        }
    }
    return resultMatrix;
}