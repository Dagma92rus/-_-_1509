// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да


int number = Convert.ToInt32(Console.ReadLine());

bool IsAliquot7and23(int arg)
{
    return arg % 7 == 0 && arg % 23 == 0; // && два апперсанта проверяет оба условия
}
if (IsAliquot7and23(number)) Console.WriteLine($"Число {number} кратно 7 и 23");
else Console.WriteLine($"Число {number} не кратно 7 и 23");
