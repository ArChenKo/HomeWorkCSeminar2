// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите целое число: ");
long a = long.Parse(Console.ReadLine()!);
long b = 1000;
long c = 1;
if(a<100)
{
    Console.Write("Третьей цифры нет.");
}
else
{
    while(a>=b)
    {
        c=c*10;
        b=b*10;
    }
    long result = a/c%10;
    Console.WriteLine(result);
}