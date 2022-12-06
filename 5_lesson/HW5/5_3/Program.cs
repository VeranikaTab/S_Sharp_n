// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] ArrayNums(int size, int start, int last)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(start, last + 1);
    return arr;
}

int CountChetn(int[] arr)
{
    int max = arr[0], min = arr[0];
    int rez = 0;

    for (int count = 0; count < arr.Length; count++)
    {
        if (arr[count] >= max)
        {
            max = arr[count];
        }
        if (arr[count] < min)
        {
            min = arr[count];
        }
    rez = max - min;
    }
    return rez;
}

int[] arr_1 = ArrayNums(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
Console.Write("Разница между максимальным и минимальным элементов массива: ");
Console.Write(CountChetn(arr_1));