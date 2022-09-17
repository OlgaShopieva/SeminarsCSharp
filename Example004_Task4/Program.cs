//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.Clear();
Console.WriteLine("Введите 1е число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2е число: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 3е число: ");
int number3 = int.Parse(Console.ReadLine());
if (number1 > number2 & number1 > number3)
{
    Console.WriteLine($"{number1} максимальное число");
}
else if (number2 > number1 & number2 > number3)
{
    Console.WriteLine($"{number2} максимальное число");
}
else if (number3 > number1 & number3 > number2)
{
    Console.WriteLine($"{number3} максимальное число");
}