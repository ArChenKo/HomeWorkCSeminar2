﻿// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int Func1()
{
    Console.Write("Введите трехзначное число: ");
    int a = int.Parse(Console.ReadLine()!);
    while (a < 100 | a > 999)
    {
        Console.Write("Нужно трехзначное число, попробуйте еще раз: ");
        a = int.Parse(Console.ReadLine()!);
    }
    int b = a % 100 / 10;
    return b;
}
int number = Func1();
Console.WriteLine("Вторая цифра во введенном числе - " + number);