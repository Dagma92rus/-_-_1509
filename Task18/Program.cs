// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());
string result = Conditions(quarter);
System.Console.WriteLine(result);

// int Conditions(int arg)
//     {
//         while (arg > 0 && arg < 5)
//         {
//         arg == 1 ? return 1
//         arg == 2 ? return 2
//         arg == 3 ? return 3
//         arg == 4 ? return 4
//         }
//     }
string Conditions(int arg)
{
    if (arg == 1) return "Диапазон координат: X > 0; Y > 0";
    if (arg == 2) return "Диапазон координат: X < 0; Y > 0";
    if (arg == 3) return "Диапазон координат: X < 0; Y < 0";
    if (arg == 4) return "Диапазон координат: X > 0; Y < 0";
    else return "Некорректный номер четверти, повторите ввод";
}

// string QuarterStr(int x, int y)
// {
//     if( x > 0 && y > 0) return "Первая четверть";
//     if( x < 0 && y > 0) return "Вторая четверть";
//     if( x < 0 && y < 0) return "Третья четверть";
//     if( x > 0 && y < 0) return "Четвёртая четверть";
//     return "Введены некоректные координаты";
// }









