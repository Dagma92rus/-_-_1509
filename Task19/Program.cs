// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.Write("Введите пятизначное число > ");
int number = Convert.ToInt32(System.Console.ReadLine()); // шаг 1: // Вводим 12821






int QuantityDigit(int arg) // шаг 2: 1) подставляем 12821; 2) узнаём количество цифр // получаем "5"
{
    int counter = default;
    while (arg > 0)
    {
        arg = arg / 10;
        counter++;
    }
    return counter;
}
int quantityDigit = QuantityDigit(number); // присваиваем "5" (quantityDigit) 
System.Console.WriteLine("Введённое число состоит из " + quantityDigit + "цифр"); 





bool MultipleOfTwo(int num) // шаг 3: проверка на чётность числа
{
    return num % 2 == 0;
}
if (MultipleOfTwo(quantityDigit)) System.Console.WriteLine($"Число {quantityDigit} чётное");
else System.Console.WriteLine($"Число {quantityDigit} нечётное");
// int oddEven = -1;
// if (MultipleOfTwo(quantityDigit)) oddEven = 1; // чётное число 
// else oddEven = 0; // нечётное число
// System.Console.WriteLine(oddEven);





int[] WritingToArray(int num, int digit) // шаг 4: запишем цифры введённого пользователем числа как элементы массива
{
    int[] arr = new int[digit];
    int res = num;
    for (int i = 0; i < digit; i++)
    {
        arr[digit-i-1] = res % 10;
        // Console.Write(arr[digit-i-1] + " "); // печатает массив от конца к началу
        res = res / 10;
    }
    return arr;
}
WritingToArray(num: number, digit: quantityDigit); // вызвал WritingToArray
int[] arrayNew = WritingToArray(num: number, digit: quantityDigit); // присвоил значение WritingToArray для arrayNew
for (int i = 0; i < 5; i++) // проверил работает ли arrayNew
{
    Console.Write(arrayNew[i] + " ");
}



int PalindromeOdd(int[] arr) // шаг 5.1: проверка на палиндром для нечётного числа/Odd
{   
    int bottomDigit = arr[0];
    int topDigit = arr[arr.Length-1];
    int oddEven = -1;
    int i = 0;
        if (bottomDigit == topDigit && i < arr.Length/2)
        {
            bottomDigit = arr[i+1];
            topDigit = arr[arr.Length-i-1];
            oddEven = 1;
        }
        else oddEven = 0;
        return oddEven;
}

if (PalindromeOdd(arrayNew) == 1) System.Console.WriteLine(" > проверка на палиндром > " + "Yes"); 
else System.Console.WriteLine(" > проверка на палиндром > " + "No"); 

// шаг 5.2: проверка на палиндром для чётного числа/Even (купите Premium)