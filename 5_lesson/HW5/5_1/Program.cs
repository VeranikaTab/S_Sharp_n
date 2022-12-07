// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
    int sum_count = 0;
    for (int count = 0; count < arr.Length; count++)
    {
        if (arr[count] % 2 == 0)
        {
            sum_count = sum_count+1;
        }   
    }
    return sum_count;
}

int[] arr_1 = ArrayNums(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
Console.Write("Количество четных чисел в массиве: ");
Console.Write(CountChetn(arr_1));
