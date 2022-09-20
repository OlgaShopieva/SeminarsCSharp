//11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа
//456 -> 46
//782 -> 72
//918 -> 98
Console.Clear();
int randomNum = new Random().Next(100,1000); // 175
Console.WriteLine (randomNum);
int a1 = randomNum / 100;
int a2 = randomNum % 10;
int a3 = (a1 * 10) + a2;
Console.WriteLine (a3);

