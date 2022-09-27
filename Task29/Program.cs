// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

// шаг 1: Запрос количества элементов массива
System.Console.Write("Введите количество элементов массива > ");
int quantity = Convert.ToInt32(System.Console.ReadLine());



// шаг 2: Задаём нижний и верхний предел элементов массива
System.Console.Write("Введите нижний предел элементов массива > ");
int bottomLimit = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите верхний предел элементов массива > ");
int topLimit = Convert.ToInt32(System.Console.ReadLine());




// шаг 3: Создаём массив с элементами в заданном диапазоне
System.Console.WriteLine($"На экране массив из {quantity} элементов в заданном диапазоне от {bottomLimit} до {topLimit}");
System.Console.Write("-> ");
int[] ArrayBottomTop(int quan, int bot, int top)
{
    int[] arr = new int[quan];
    // int index = 0;
    // arr[index] = Random.()
    Random rnd = new Random(); // иначе будут только 0 или только 1
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(bot, top+1);
        System.Console.Write(arr[i] + " ");
    }
    return arr;
}
int[] randomArray = ArrayBottomTop(quantity, bottomLimit, topLimit);