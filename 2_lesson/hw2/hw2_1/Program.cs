// Задача 1: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

string Cif(int num)
{
    if ((-1000 < num && num < -99) || (num < 1000 && num > 99))
    {
        return $"{num / 10 % 10}";
    }
    else
    {
        return ("Число не трехзначное");
    }
}
Console.WriteLine(Cif(int.Parse(Console.ReadLine())));

//

Console.WriteLine("Ведите число: ");
string a = (Console.ReadLine());
int a1 = int.Parse(a);
if ((-1000 < a1 && a1 < -99) || (a1 < 1000 && a1 > 99))
{
    int a2 = a1 / 10;
    int a3 = a2 % 10;
    Console.WriteLine(a3);
}
else
{
    Console.WriteLine("Число не трехзначное");
}
