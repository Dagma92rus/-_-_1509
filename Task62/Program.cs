// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// решение
int[,] matrixCurrent = new int[6, 6];
RecordSpiral(matrixCurrent, 0, 0, current: 2);
PrintMatrix(matrixCurrent);


// перечень методов


// метод записи элементов матрицы по спирали
void RecordSpiral(int[,] matrix, int i, int j, int current)
{
    // System.Console.WriteLine(matrix[i, j]);
    if (matrix[i, j + 1] != 0) return;
    matrix[0, 0] = 1;

    // направо
    for (j += 1; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == 0)
        {
            matrix[i, j] = current;
            current++;
        }
        else break;
    }

    // вниз
    j--;
    for (i += 1; i < matrix.GetLength(0); i++)
    {
        if (matrix[i, j] == 0)
        {
            matrix[i, j] = current;
            current++;
        }
        else break;
    }

    // налево
    i--;
    for (j -= 1; j > -1; j--)
    {
        if (matrix[i, j] == 0)
        {
            matrix[i, j] = current;
            current++;
        }
        else break;
    }

    // вверх
    j++;
    for (i -= 1; i > 0; i--)
    {
        if (matrix[i, j] == 0)
        {
            matrix[i, j] = current;
            current++;
        }
        if (matrix[i - 1, j] != 0) break;
    }
    RecordSpiral(matrix, i, j, current);
}

// метод печати матрицы 
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j],5}");
        }
        System.Console.WriteLine();
    }
}