// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// 13 -> 1101

System.Console.WriteLine("Введите число для преобразование его в двоичное");
int number = Convert.ToInt32(System.Console.ReadLine());
int binaryNumber = ConvertNumberToBinary(number);
System.Console.WriteLine($"{number} -> {binaryNumber}");
int ConvertNumberToBinary(int num)
{
    int binaryNum = 0;
    int count = 1;
    while (num > 0)
    {
        binaryNum = binaryNum + num % 2 * count; // 0 + 3/2 * 1 = 1 // 1 + 1 * 10 = 11
        count = count*10; // 10 // 100
        num = num / 2; // 3/2 = 1 // 0
    }
    return binaryNum;
}
// int number = 13;
// DecToBin(number);

// void DecToBin(int num)
// {
//     if (num == 0) return;
//     DecToBin(num / 2);
//     Console.Write(num % 2);
// }
