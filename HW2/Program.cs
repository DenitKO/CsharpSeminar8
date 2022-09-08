// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void HighestSumInRow(int[,] array)
{
    int[] sumOfRow = new int[array.GetLength(0)];
    int minSum = 0;
    int min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumOfRow[i] = sumOfRow[i] + array[i, j];
        }
        if (i == 0) minSum = sumOfRow[0];
        if (sumOfRow[i] < minSum)
        {
            minSum = sumOfRow[i];
            min = i;
        }
    }
    Console.Write($"строка с наименьшей суммой элементов: {min + 1} строка");
}

int[,] matrix = new int[4, 4];

FillMatrixArray(matrix);
PrintMatrixArray(matrix);
Console.WriteLine();
HighestSumInRow(matrix);