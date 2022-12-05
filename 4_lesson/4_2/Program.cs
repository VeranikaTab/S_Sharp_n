// 2. Напишите программу, которая принимает на вход
//    число N и выдаёт произведение чисел от 1 до N.

int PowNum(int num)
{
    int all_mul = 1;
    for (int i = 1; i <= num; i++)
    {
        all_mul *= i;
    }
    return all_mul;
}

string answer = Console.ReadLine();
int ans = answer == null ? 0 : int.Parse(answer);
Console.WriteLine(PowNum(ans));
