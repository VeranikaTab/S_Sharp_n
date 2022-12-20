// 3. Напишите программу, которая будет принимать на вход число
// и возвращать сумму его цифр. Использовать рекурсию.

int Sum(int num)
{
    if (num == 0) return 0;
    return Sum(num / 10) + num % 10;

}
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма цифр числа равна: ");
Console.WriteLine(Sum(num));

