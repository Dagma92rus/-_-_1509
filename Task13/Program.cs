// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool NoThirdDigit(int arg)
{
    return arg / 100 < 1;
};

int ThirdDigit(int arg)
{
    while (arg > 999)
    {
        arg = arg / 10;
    };
    return arg % 10;
};

int result = (ThirdDigit(number));
if (NoThirdDigit(number)) Console.WriteLine("Третьей цифры нет");
else
{
    Console.WriteLine($"Третья цифра равна {result}");
};

