// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Multiply(int num)
{
    int res = 1;
    for (int i = 1; i <= num; i++)
    {
        res = res * i;
    }
    return res;
}
if (number > 0)
{
    Console.WriteLine($"{Multiply(number)}");
}
else Console.WriteLine("Введите положительное число");
