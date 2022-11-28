// Задача 1: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Ведите число: ");
string a = (Console.ReadLine());
int a1 = int.Parse(a);
if (a1 < 999 && a1 > 99)
{
    int a2 = a1 / 10;
    int a3 = a2 % 10;
    Console.WriteLine(a3);
}
else
{
Console.WriteLine("Число не трехзначное");
}