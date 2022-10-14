// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int minNumber = 1;
int maxNimber = 9;
// шаг 1: создаём трёхмерный массив со случайными числами. Выводим на печать каждый элемент с его индексами
int[,,] matrixRndInt = CreateMatrixRndInt(2, 2, 2, minNumber, maxNimber);
PrintMatrix(matrixRndInt);
// шаг 2: проверяем массив на неповторяющиеся элементы
    // 2.1: записываем элементы трёхмерного массива в одномерный
int[] oneDimensionalArray = ThreeToOneArray(matrixRndInt);
System.Console.WriteLine();
PrintArray(oneDimensionalArray);
    // 2.2: заменяем в массиве повторяющееся элементы
SwapRepeatElements(oneDimensionalArray, minNumber, maxNimber);
PrintArray(oneDimensionalArray);
    // 2.3: делаем проверку на повторяющиеся элементы, если есть возвращаемся в пункту 2.2
ElementsDictionary(oneDimensionalArray);
        // 2.3.1: зацикливаем проверку из 2.3 до тех пор, пока проверка не обнаружит ни одного совпадения
CycleFullDeleteRepeatElements();
PrintArray(oneDimensionalArray);
System.Console.WriteLine();
// шаг 3: записываем элементы одномерного массива обратно в трёхмерный
int[,,] matrixRndIntNotRepeatNumbers = OneToThreeArray(oneDimensionalArray, matrixRndInt);
PrintMatrix(matrixRndIntNotRepeatNumbers);

// метод создания трёхмерного массива
int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = rnd.Next(min, max + 1);
            }
        }
    }
    return matrix;
}
// метод печати трёхмерного массива 
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        System.Console.WriteLine("Измерение № " + i);
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write($"{matrix[i, j, k],8}({i},{j},{k})");
            }   
        }
        System.Console.WriteLine();
    }
}
// метод записи элементов трёхмерного массива в одномерный
int[] ThreeToOneArray(int[,,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1) * matrix.GetLength(2)];
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                array[n] = matrix[i, j, k];
                n++;
            }
        }
    }
    return array;
}
// метод замены повторяющихся элементов одномерного массива
void SwapRepeatElements(int[] array, int min, int max)
{
    var rnd = new Random();
    int current = array[0];
    for (int j = 0; j < array.Length; j++)
    {
        current = array[j];
        for (int i = 1; i < array.Length; i++)
        {
            if (current == array[i] && j != i)
            {
                int temp = rnd.Next(min, max + 1);
                System.Console.WriteLine($"Заменяем {array[i]} на {temp}");
                array[i] = temp;
                i = 1;
                j = 0;
                current = array[0];
            }
        }
    }
}
// метод проверки одномерного массива на повторяющиеся элементы 
bool ElementsDictionary(int[] array)
{
    int current = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == current) 
        {
            System.Console.WriteLine("Найдено повторение");
            SwapRepeatElements(oneDimensionalArray, minNumber, maxNimber);
        }
    }
    return true;
}
// метод повторного запуска до полного устранения повторяющихся элементов
void CycleFullDeleteRepeatElements()
{
    while (ElementsDictionary(oneDimensionalArray) == true) 
    {
        System.Console.WriteLine("Ура, повторений не найдено!");
        break;
    }
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
// метод записи элементов одномерного массива в трёхмерный
int[,,] OneToThreeArray(int[] array, int[,,] matrix)
{
    int n = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = array[n];
                n++;
            }
        }
    }
    return matrix;
}
