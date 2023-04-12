// Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("1-Понедельник.");
Console.WriteLine("2-Вторник.");
Console.WriteLine("3-Среда.");
Console.WriteLine("4-Четверг.");
Console.WriteLine("5-Пятница.");
Console.WriteLine("6-Суббота.");
Console.WriteLine("7-Воскресенье.");
Console.WriteLine("Введите цифрру выбранного дня недели.");
int a = 0;
while (a < 1 | a > 7)
{
    Console.Write("Нужно ввести цифру от 1 до 7: ");
    a = int.Parse(Console.ReadLine()!);
}   
if (a > 5)
    Console.WriteLine("Поздравляем! Вы выбрали выходной!");
else
    Console.WriteLine("Вы выбрали будний день, придется поработать.)");