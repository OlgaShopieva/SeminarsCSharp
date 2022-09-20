// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Clear();

Console.WriteLine("Введите число: ");
string num = Console.ReadLine();

if (num.Length >= 3)
{
    Console.WriteLine($"Третья цифра числа {num}: {num.ToString()[2]}");
}
else
{
    Console.WriteLine($"Третьей цифры в числе {num} нет");
}