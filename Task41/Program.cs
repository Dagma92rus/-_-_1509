// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// шаг 1: Ввести размерность массива и заполнить его с клавиатуры
System.Console.Write("Введите размерность массива -> ");
int sizeArray = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine($"Введите {sizeArray} элементов массива: ");
int[] handArray = new int[sizeArray];
for (int i = 0; i < sizeArray; i++)
{
    handArray[i] = Convert.ToInt32(System.Console.ReadLine());
}
// шаг 2: Посчитать сколько положительных было введено
PrintArray(handArray);
int numElementsPositive = NumElementsPositive(handArray);
System.Console.WriteLine("Количество положительных элементов в введённом массиве составило -> " + numElementsPositive);

// метод печати 
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
// метод подсчёта положительных элементов массива
int NumElementsPositive(int[] array)
{
    int count = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}


