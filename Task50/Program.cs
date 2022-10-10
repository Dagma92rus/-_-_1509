// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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
// шаг 2: получаем на вход позицию элемента матрицы
System.Console.WriteLine("Введите номер строки и столбца элемента матрицы ->");
int setRow = Convert.ToInt32(System.Console.ReadLine());
int setColumn = Convert.ToInt32(System.Console.ReadLine());
// шаг 3: используем полученные данные для поиска элементы матрицы
FindSetElement(matrix, setRow, setColumn);

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
// метод печати массива 
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j],6}");
        }
        System.Console.WriteLine();
    }
}
// метод поиска элемента на заданной позиции
void FindSetElement(int[,] matrix, int row, int column)
{
    if (row > matrix.GetLength(0)-1 || column > matrix.GetLength(1)-1) System.Console.WriteLine("Выход за пределы матрицы");
    else System.Console.WriteLine($"Элемент на позиции [{row}, {column}] равен -> {matrix[row, column]}");
}