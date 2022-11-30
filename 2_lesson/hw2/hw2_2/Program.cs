// Задача 2: Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.
// 645 -> 65
// 782 -> 72
// 918 -> 98

void New(int num)
{
    if ((-1000 < num && num < -99) || (num < 1000 && num > 99))
    { 
        int j = num / 100;
        int k = num % 10;
        int n = j * 10 + k;
        Console.WriteLine(num);
        Console.WriteLine(n);
    }
    else
    {
    Console.WriteLine("Число не трехзначное");
    }
}
New(new Random().Next(99, 1000));

//

string Cif(int num)
{
    if ((-1000 < num && num < -99) || (num < 1000 && num > 99))
    {
        return $"{((num / 100)*10) + (num % 10)}";
    }
    else
    {
        return ("Число не трехзначное");
    }
}
Console.WriteLine(Cif(int.Parse(Console.ReadLine())));