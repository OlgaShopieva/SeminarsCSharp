// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();
Console.Write("Введите количество строк 1й матрицы: ");
int rowsA = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 1й матрицы: ");
int columnsA = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк 2й матрицы: ");
int rowsB = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов 2й матрицы: ");
int columnsB = int.Parse(Console.ReadLine());

int[,] MatrixA = FillArray(rowsA, columnsA, 0, 10);
int[,] MatrixB = FillArray(rowsB, columnsB, 0, 10);
Console.WriteLine("Первая матрица: ");
PrintArray(MatrixA);
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
PrintArray(MatrixB);
Console.WriteLine();
Console.WriteLine("Результат умножения матриц: ");
PrintArray(MultiplyMatrix(MatrixA, MatrixB));

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

int[,] MultiplyMatrix(int[,] matrA, int[,] matrB)
{
    int[,] matrC = new int[matrA.GetLength(0), matrB.GetLength(1)];
    for (int i = 0; i < matrA.GetLength(0); i++)
    {
        for (int j = 0; j < matrB.GetLength(1); j++)
        {
            for (int k = 0; k < matrA.GetLength(1); k++)
            {
                matrC[i, j] += matrA[i, k] * matrB[k, j];
            }
        }
    }
   
   return matrC; 
   } 

