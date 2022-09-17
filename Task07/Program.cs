// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("введите число:");
int N = Convert.ToInt32(Console.ReadLine());// Запрашиваем число
int[] myArray = new int [] {0,0,0,0};
int current = 2;
for (int count = 0; current <= N; count++)
    {
        myArray [count] = current;
        current+=2;
        Console.WriteLine(myArray [count]); 
    }