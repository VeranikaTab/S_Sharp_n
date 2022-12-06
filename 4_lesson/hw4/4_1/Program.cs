// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. Без модуля Math, используем цикл for.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Step(int num)
{
    int n = int.Parse(Console.ReadLine());
    Console.Write($"{num} в степени ");
    Console.Write($"{n}-> ");
    
    int result = num;
    for (int i = 1; i < n; i++)
    {
        result *= num; 
    }
    return result;
}
Console.WriteLine(Step(int.Parse(Console.ReadLine())));

// 2-й вариант

double PowNum(int a, int b)
{   
    double n_pow = 1;
    int b_abs = Math.Abs(b);
    
    for (int i = 1; i <= b_abs; i++)
    {
        if (b > 0)
            n_pow *= a; 
        else
            n_pow /= a;
    }  
    return n_pow;  
}

Console.WriteLine("Enter a number: ");
int num_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter degree of number: ");
int num_2 = int.Parse(Console.ReadLine());

Console.WriteLine(PowNum(num_1, num_2));


