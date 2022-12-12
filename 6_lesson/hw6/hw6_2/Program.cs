// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Peresechenie(double b1, double k1, double b2, double k2)
{
    double x = 0;
    double y = 0;
    if (b1 == b2 && k1 == k2) Console.WriteLine("Две прямые Совпадают");
    else if (k1 == k2 && b1 != b2) Console.WriteLine("Две прямые Параллельны");
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = (k1 * (b2 - b1) / (k1 - k2) + b1);
        Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
    }

}
Peresechenie(int.Parse(Console.ReadLine()),
       int.Parse(Console.ReadLine()),
       int.Parse(Console.ReadLine()),
       int.Parse(Console.ReadLine()));

// 2. Напишите программу, которая найдёт точку пересечения двух прямых,
//    заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения
//    b1, k1, b2 и k2 задаются пользователем.
//    https://studok.net/obrazovanie-i-kommunikacii/vopros-kak-vychislit-tochku-peresechenija-dvuh-prjamyh/


void Intersection(double k1, double b1, double k2, double b2)
{
    double k_sub = k1 - k2;
    if (k_sub != 0)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Intersection point: ({x}; {y})");
    }
    else if (k1 == k2 && b1 == b2)
        Console.WriteLine("There are an infinite number of intersection points.");
    else
        Console.WriteLine("There is no intersection point");
}

//  1, 4, 2, 3
// -1, -2, -1, 2
Intersection(int.Parse(Console.ReadLine()),
             int.Parse(Console.ReadLine()),
             int.Parse(Console.ReadLine()),
             int.Parse(Console.ReadLine()));
