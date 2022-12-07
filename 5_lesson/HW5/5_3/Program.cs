// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        
        Console.Write($"{Math.Round(arr[i],2)}  ");
    Console.WriteLine();
    
}

double[] ArrayNums(int size, int first, int last)
{
    double[] arr = new double[size];
    Random random = new Random();
    // double[] arr = {3,7,22,2,78}; массив можно инициализировать
    
    for (int i = 0; i < size; i++)
        
        //arr[i] = random.NextDouble() * 40;
        arr[i] = random.Next(first, last) + random.NextDouble();

    return arr;   
}

double CountChetn(double[] arr)
{
    double max = arr[0]; double min = arr[0];
    double rez = 0;

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

double[] arr_1 = ArrayNums((int.Parse(Console.ReadLine())), (int.Parse(Console.ReadLine())), (int.Parse(Console.ReadLine())));



Print(arr_1);
//string rez = arr.ToString("#,##");

Console.Write("Разница между максимальным и минимальным элементов массива: ");
Console.Write(Math.Round(CountChetn(arr_1), 2));

