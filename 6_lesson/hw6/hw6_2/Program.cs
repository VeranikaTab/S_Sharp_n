// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Peresechenie(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    if (b1 == b2 && k1 == k2) Console.WriteLine("Совпадают");
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = (k1 * (b2 - b1) / (k1 - k2) + b1);
    }
    Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}
Peresechenie(int.Parse(Console.ReadLine()),
       int.Parse(Console.ReadLine()),
       int.Parse(Console.ReadLine()),
       int.Parse(Console.ReadLine()));
