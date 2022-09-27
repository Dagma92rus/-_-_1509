// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// шаг 1: введение числа
System.Console.Write("Введите число > ");
int number = Math.Abs(Convert.ToInt32(System.Console.ReadLine()));



// шаг 2: количество цифр в числе
int QuantityDigit(int arg)
{
    int counter = default;
    while (arg > 0)
    {
        arg = arg / 10;
        counter++;
    }
    return counter;
}
int quantityDigit = QuantityDigit(number);



// шаг 3: запись цифр из введённого числа в качестве элементов массива
int[] WritingToArray(int num, int quanD) // шаг 4: запишем цифры введённого пользователем числа как элементы массива
{
    int[] arr = new int[quanD];
    int res = num;
    for (int i = 0; i < quanD; i++)
    {
        arr[quanD-i-1] = res % 10;
        // Console.Write(arr[quanD-i-1] + " "); // печатает массив от конца к началу
        res = res / 10;
    }
    return arr;
}
int[] numberToArray = WritingToArray(number, quantityDigit);



// шаг 4: сложение элементов массива // сумма цифр в числе
int SumDigit(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
}
System.Console.Write($"Cумма цифр в числе {number} = " + SumDigit(numberToArray));