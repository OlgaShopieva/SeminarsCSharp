//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.Clear();
Console.WriteLine("Введите натуральное число: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
for (i = 1; i <= N; i++)
if (i%2==0)
Console.WriteLine(i);