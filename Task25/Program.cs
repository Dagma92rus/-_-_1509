// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16






// натуральную степень или правильней неотрицательную? условие отдельное для нуля что ли вывести. 
// если это узко-направленная, специфичная задача, то в примере стоило указать: 3, 0 -> "введите натуральную степень!"
// но я оставляю универсальное решение






// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в неотрицательную степень B.
System.Console.WriteLine("Введите число > ");
int number = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine("Введите степень возведения для числа " + number + " > ");
int degree = Convert.ToInt32(System.Console.ReadLine());

int RaiseToDegree(int num, int deg)
{
    int result = Convert.ToInt32(Math.Pow(num, Math.Abs(deg)));
    return result;
}
System.Console.Write("Возведённое в степень число = " + RaiseToDegree(number, degree));