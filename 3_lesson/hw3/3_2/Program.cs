// Задача 21 Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Формула вычисления расстояния между двумя точками A(xa, ya, za) и B(xb, yb, zb) в пространстве:
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2



double Distan(float xa, float ya, float za, float xb, float yb, float zb)
{
    return Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));    
}

Console.WriteLine(Math.Round(Distan(3, 6, 8, 2, 1, -7), 2));
Console.WriteLine(Math.Round(Distan(7, -5, 0, 1, -1, 9), 2));