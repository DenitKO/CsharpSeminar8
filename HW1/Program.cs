// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FillMatrixArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintMatrixArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[] array)
{
    int max = array[0];
    int maxIndex = 0;
    Boolean isMax = false;
    for (int n = 0; n < array.Length; n++)
    {
        max = array[n];
        for (int i = n+1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
                isMax = true;
            }
        }
        if (isMax)
        {
            array[maxIndex] = array[n];
            array[n] = max;
            isMax = false;
        }
    }
}

void ToMaxSortArray(int[,] array)
{
    int[] temp = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            temp[j] = array[i, j];
        SortArray(temp);
        for (int k = 0; k < array.GetLength(1); k++)
            array[i, k] = temp[k];
    }
}

int[,] matrix = new int[3, 4];

FillMatrixArray(matrix);
PrintMatrixArray(matrix);
Console.WriteLine();
ToMaxSortArray(matrix);
PrintMatrixArray(matrix);