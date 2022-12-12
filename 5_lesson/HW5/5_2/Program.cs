// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumNechetPos(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i=i+2)
    {
        sum = sum + arr[i];  
    }
    return sum;
}

int[] arr_1 = ArrayNums(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
Console.Write("Cумма элементов, стоящих на нечётных позициях: ");
Console.Write(SumNechetPos(arr_1));

//