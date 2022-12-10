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

double MaxMin(double[] arr)
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
Console.Write("Разница между максимальным и минимальным элементов массива: ");
Console.Write(Math.Round(MaxMin(arr_1), 2));




//////////////////////////////

// 3. Задайте массив вещественных чисел. 
//    Найдите разницу между максимальным и минимальным элементов массива. 
//    https://docs.microsoft.com/en-us/dotnet/api/system.random.nextdouble?view=net-6.0
//    https://ru.stackoverflow.com/questions/1254105/%D0%9A%D0%B0%D0%BA-%D1%81%D0%B3%D0%B5%D0%BD%D0%B5%D1%80%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D1%82%D1%8C-%D1%81%D0%BB%D1%83%D1%87%D0%B0%D0%B9%D0%BD%D0%BE%D0%B5-%D0%B4%D1%80%D0%BE%D0%B1%D0%BD%D0%BE%D0%B5-%D1%87%D0%B8%D1%81%D0%BB%D0%BE-%D0%B8%D0%B7-%D0%B8%D0%BD%D1%82%D0%B5%D1%80%D0%B2%D0%B0%D0%BB%D0%B0


void Print(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)    
        Console.Write($"{arr[i]} ");
    
    Console.WriteLine();
}

double[] MassNums(int size, int from, int to)
{
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 1; i < size; i++)    
        arr[i] = Math.Round(n_new.NextDouble() * (from + to) - from, 2);
    
    return arr;
}

void DiffMaxMin(double[] arr)
{
    double n_max = arr[0];
    double n_min = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (n_max < arr[i])        
            n_max = arr[i];
        
        else if (n_min > arr[i])        
            n_min = arr[i];        
    }

    Console.Write($"Max: {n_max}, min: {n_min}. ");
    Console.WriteLine($"Difference: {n_max} - ({n_min}) = {Math.Round(n_max - n_min, 2)}");
}

// 10, 10, 12
double[] arr_1 = MassNums(int.Parse(Console.ReadLine()),
                          int.Parse(Console.ReadLine()),
                          int.Parse(Console.ReadLine()));
Print(arr_1);
DiffMaxMin(arr_1);
