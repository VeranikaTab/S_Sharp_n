// 4. Напишите программу, которая на вход принимает два числа A и B,
//    и возводит число А в целую степень B с помощью рекурсии.

int Degree (int a, int b)
{
    if(b == 0) return 1;
    return Degree(a, b-1) * a;
}



Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.Write("число А в степени B: ");

Console.WriteLine(Degree(a,b));