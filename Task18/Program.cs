// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти");
int quarter = Convert.ToInt32(Console.ReadLine());

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

    if (quarter == 1) Console.WriteLine("Диапазон координат: X > 0; Y > 0");
    else if (quarter == 2) Console.WriteLine("Диапазон координат: X < 0; Y > 0");
    else if (quarter == 2) Console.WriteLine("Диапазон координат: X < 0; Y < 0");
    else if (quarter == 2) Console.WriteLine("Диапазон координат: X > 0; Y < 0");
    else Console.WriteLine("Некорректный номер четверти, повторите ввод");








