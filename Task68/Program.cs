// Home Work 9
// Задача 68: Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int numM = 3;
int numN = 5;
FunctionAccerman(numM, numN);
System.Console.WriteLine($"Функция Аккермана A(m, n) со значения m = {numM} и n = {numN} равняется -> {FunctionAccerman(numM, numN)}");

int FunctionAccerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return FunctionAccerman(m - 1, 1);
    if (m > 0 && n > 0) return FunctionAccerman(m - 1, FunctionAccerman(m, n - 1));
    return FunctionAccerman(numM, numN);
}



// без рекурсии
// double result = Function(numM, numN);
// System.Console.WriteLine(result);
// double Function(double m, double n)
// {
//     double sum = default;
//     if (m == 0) sum += n + 1;
//     if (m == 1) sum += n + 2;
//     if (m == 2) sum += 2 * n + 3;
//     if (m == 3) sum += Math.Pow(2, n + 3) - 3;
//     return sum;
// }