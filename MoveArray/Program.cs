// Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
// Дополнительная задача (задача со звёздочкой): Напишите программу, которая задаёт массив из n элементов, которые необходимо заполнить случайными значениями и сдвинуть элементы массива влево, или вправо на 1 позицию.
// [8, 5, 1, 7, 0] - [5, 1, 7, 0, 8] - сдвиг влево
// [8, 5, 1, 7, 0] - [0, 8, 5, 1, 7] - сдвиг вправо
Console.Clear();

Console.WriteLine("Введите число: ");
int arrayLength  = Convert.ToInt32(Console.ReadLine());

int[] MyArray = FillArray(arrayLength, 0, 10);

Console.WriteLine("Исходный массив: ");
PrintArray(MyArray);

MoveArray(MyArray);

Console.WriteLine("Изменённый массив: ");
PrintArray(MyArray);

int[] FillArray(int size, int min, int max) 
{
    int[] filledArray = new int[size];

    for (int i = 0; i < filledArray.Length; i++)
    {
        filledArray[i] = new Random().Next(min, max + 1);
    }
    return filledArray;
}

void PrintArray(int[] arr) 
{
    Console.WriteLine("\n [" + String.Join(",", arr) + "]");
}

void MoveArray(int[] Arr)
{
    int x = Arr[0];
    for (int i = 0; i < Arr.Length - 1; i++)
        Arr[i] = Arr[i + 1];
    Arr[Arr.Length - 1] = x;
}
