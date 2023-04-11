// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine()!);
while (a < 99 | a > 999)
{
    Console.Write("Нужно трехзначное число, попробуйте еще раз: ");
    a = int.Parse(Console.ReadLine()!);
}
int b = a % 100 / 10;
Console.WriteLine("Вторая цифра во введенном числе - " + b);