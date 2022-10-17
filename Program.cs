// Задача 64: Задайте значения N и M. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> 2, 4
// M = 4; N = 8 -> 4, 6, 8
Console.Clear();

int n = 1;

void Recurs(int n, int i = 10)
{
    if (n < i && n % 2 == 0)
    {
     
        Console.WriteLine(n);
        n++;
        Recurs(n, i);
      
    }
    else return;
}

Recurs(n);