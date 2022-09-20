// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8
// 99 -> цифры равны

//int number = 99; //new Random().Next(10, 100); //некст генерирует целыe числа; некстдабл генерирует вещественные числа
// Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");
// int firstDigit = number / 10;
// int secondDigit = number % 10;
// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа {number} = {firstDigit}");
// Console.WriteLine($"Наибольшая цифра числа {number} = {secondDigit}");

int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    // if (firstDigit > secondDigit) return firstDigit; // 20-23 новый этап
    // return secondDigit;
    if (firstDigit == secondDigit) return 0;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
    // if () return 0; // исключение 
}
int number = new Random().Next(10, 100);
int maxDigit = MaxDigit(number);
string result = maxDigit > 0 ? maxDigit.ToString() : "Цифры равны";
Console.WriteLine($"Наибольшая цифра числа {number} = {result}");