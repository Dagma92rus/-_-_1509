// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// System.Console.Write("Введите размер массива > ");
// int number = Convert.ToInt32(System.Console.ReadLine());
// int[] array = new int[number];

// int[] RandomArr_1_0(int[] arr)
// {
//     Random rnd = new Random(); // иначе будут только 0 или только 1
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = rnd.Next(0, 2);
//     }
//     return arr;
// }



// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     int position = 0;
//     while (position<count)
//     {
//         Console.Write(array[position]);
//         position++;
//     }
// }
// PrintArray(array);
// int[] arrayNew = RandomArr_1_0(array);

// Console.WriteLine($"    {RandomArr_1_0(number)}");




// by Диана
int[] array = new int[8];
int[] arrayNew = FoolArray(array);

PrintArray(arrayNew);

int[] FoolArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}

void PrintArray (int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(array[position]);
        position++;
    }
}





// by Ilya Vladimirovich
// int[] array = new int[8];
// GetArray(array);
// PrintArray(array);

// void GetArray(int[] arr)
// {
//     int length = arr.Length;
//     Random rnd = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         arr[i] = rnd.Next(0, 2);
//     }
// }
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }
