// 2. Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// https://ru.onlinemschool.com/math/library/analytic_geometry/point_point_length/
// AB = √(xb - xa)2 + (yb - ya)2 - Формула вычисления
// расстояния между двумя точками A(xa, ya) и B(xb, yb) на плоскости:

double Distan(float x1, float y1, float x2, float y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));    
}

Console.WriteLine(Distan(3, 6, 2, 1));
Console.WriteLine(Distan(7, -5, 1, -1));


// 2-й вариант
int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
double Distance(int ax, int ay, int bx, int by)
{
    double result;
    result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
    return result;
}

int ax = ReadNumber("Введите ax: ");
int ay = ReadNumber("Введите ay: ");
int bx = ReadNumber("Введите bx: ");
int by = ReadNumber("Введите by: ");

Console.WriteLine(Math.Round(Distance(ax, ay, bx, by), 2));
