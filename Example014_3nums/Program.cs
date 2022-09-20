// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.Clear();

Console.WriteLine("Введите трёхзначное число");
string num = (Console.ReadLine());

if (num.Length == 3)
{
 Console.WriteLine($"Вторая цифра числа {num}: {num.ToString()[1]}");
}
else
{
    Console.WriteLine("Вы ввели не трёхзначное число");
}

