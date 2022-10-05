// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();


Console.Write ("Введите количество цифр: ");
int ArrayLength = int.Parse(Console.ReadLine());
int[] myArray = new int [ArrayLength];

for (int i = 0; i < myArray.Length; i++)
{
   Console.WriteLine ("Введите числа по порядку: "); 
   myArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine ("Все введённые числа: ");
for (int i = 0; i < myArray.Length; i++)
{
   Console.Write(" " + myArray[i]);
}
Console.ReadLine();

int positiveSum = 0;
foreach(int element in myArray){
    positiveSum += element > 0 ? 1 : 0;
}
Console.WriteLine("Количество чисел больше нуля: " + positiveSum);