// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int [,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);
System.Console.WriteLine();

GetSquareEvenElem(array2D);
PrintMatrix(array2D);

// метод создания двумерного массива случайными числами
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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
// метод возведение чётных элементов массива в квадрат
void GetSquareEvenElem(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)  //rows (0)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2) //columns (1)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}
// метод печати двумерного массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
            else Console.Write($"{matrix[i, j], 4}");
        }
         Console.WriteLine("|");
    }
}

