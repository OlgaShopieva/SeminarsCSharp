//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

Console.Clear();

Console.WriteLine ("Введите 1е число");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine ("Введите 2е число");
int number2 = int.Parse(Console.ReadLine());

int num = 0;
if (number1 % number2 == 0)
{
    Console.WriteLine ("кратно");
}
else 
{
    num = number1 % number2;
    Console.WriteLine($"не кратно, остаток {num} ");
}


