// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] collection) //метод заполнения массива
{
    int Length = collection.Length;
    
    for (int index = 0; index < Length; index++)
    {
        collection[index] = new Random(). Next(1, 10);
        //collection[index] = int.Parse(Console.ReadLine());
    }
}

//метод который печатает массив
void PrintArray(int[] col)
{
    int count = col.Length;
    
    for (int position = 0; position < count; position++)
    {
        Console.Write($"{col[position]} ");
    }
}
//Console.Write("Введите количество элементов массива: ");
//int[] array = new int [(int.Parse(Console.ReadLine()))];
int[] array = new int [8]; 
FillArray(array);
PrintArray(array);


//2-й вариант

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] EightMass(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(1, 100);
    return arr;
}

int[] arr_1 = EightMass(int.Parse(Console.ReadLine()));
Print(arr_1);
int[] arr_2 = EightMass(int.Parse(Console.ReadLine()));
Print(arr_2);










