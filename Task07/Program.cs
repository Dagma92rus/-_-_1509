// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("введите число:");
// int N = Convert.ToInt32(Console.ReadLine());    // Запрашиваем число
// int[] myArray = new int [] {0,0,0,0};           // Не разобрался как в таком случае выводить массив, поэтому он у меня на 4 ячейки... пока
// int current = 2;
// for (int count = 0; current <= N; count++)
//     {
//         myArray [count] = current;
//         current+=2;
//         Console.WriteLine(myArray [count]); 
//     }


Console.WriteLine("введите число:");
int N = Convert.ToInt32(Console.ReadLine());
int current = 2;
Console.Write($"Все чётные числа от 1 до N = {N}: ");
while (current <= N)
{
    Console.Write(current + ", ");
    current+=2;
}