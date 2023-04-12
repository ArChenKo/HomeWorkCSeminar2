// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите целое число: ");
long a = long.Parse(Console.ReadLine()!);
if(a<100)
    Console.Write("Третьей цифры нет.");
else
{
    while(a>999)
        a/=10;
    long result = a%10;
    Console.WriteLine(result);
}