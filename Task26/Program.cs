// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

System.Console.WriteLine("Загадайте число > ");
int newNumber = Math.Abs(Convert.ToInt32(Console.ReadLine()));

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
Console.WriteLine($"Ваше число {newNumber} состоит из {QuantityDigit(newNumber)} цифр");
