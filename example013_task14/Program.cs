//14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.Clear();
int a = (int.Parse(Console.ReadLine()));

if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine ("да");
}
else
{
    Console.WriteLine ("нет");
}