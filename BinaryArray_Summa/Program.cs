// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача (задача со звёздочкой): Задайте двумерный массив из целых чисел. Определите, есть столбец в массиве, сумма которого, больше суммы элементов расположенных в четырех "углах" двумерного массива.
// Например, задан массив:
// 4 4 7 5
// 4 3 5 3
// 8 1 6 8 -> нет

// 2 4 7 2
// 4 3 5 3
// 2 1 6 2 -> да

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rowCount = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columnCount = int.Parse(Console.ReadLine());

int[,] array = FillArray(rowCount, columnCount, 1, 10);
PrintArray(array);

int [] NewArray = SummaColumns(array);
Console.WriteLine("Суммы столбцов:" + String.Join("|", NewArray));

int sum = Convert.ToInt32(SumCorners (array));
Console.WriteLine("Сумма углов массива: " + sum);

CheckColumns(NewArray);


int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] filledArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return filledArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(" " + inputArray[i, j]);
        }
        Console.WriteLine();
    }
}

int[] SummaColumns(int[,] arr)
{
    int[] LocalArray = new int[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[j, i];
        }
        LocalArray[i] = sum;
    }
    return LocalArray;
}

int SumCorners (int[,] array_l)
{
    int SummaCorners = (array_l[0, 0] + array_l[0, array_l.GetLength(0) - 1] + array_l[array_l.GetLength(1) - 1, 0] + array_l[array_l.GetLength(0) - 1, array_l.GetLength(1) - 1]);
    return SummaCorners;
}

void CheckColumns  (int [] arrL)
{
    for (int i = 0; i < arrL.Length; i++)
    {
        if (arrL[i] > sum)
        {
            Console.WriteLine("Да, в массиве есть столбец, сумма элементов которого больше суммы углов");
            break;
        }
    }
   
}