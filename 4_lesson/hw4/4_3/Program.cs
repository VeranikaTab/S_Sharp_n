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










