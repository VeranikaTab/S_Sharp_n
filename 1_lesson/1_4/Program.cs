// 4. Напишите программу вычисления модуля числа.

Console.WriteLine("введите число: ");
var s = Console.ReadLine();
int N = s == null ? 0 : int.Parse(s);
Console.WriteLine($"{Math.Abs(N)}");