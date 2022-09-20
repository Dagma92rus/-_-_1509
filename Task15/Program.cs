// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

bool CorrectDigit(int arg)
{
    return arg > 0 && arg < 8;
}

bool DayOfWeek(int arg)
{
    return arg == 6 || arg == 7;
}
if (CorrectDigit(number))
{
    if (DayOfWeek(number))
    {
        Console.WriteLine("Выходной");
    } 
    else
    {
        Console.WriteLine("Будний");
    }
}
else
{
     Console.WriteLine("...от 1 до 7!");
}