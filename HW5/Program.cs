// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillBagelArray(int[,] array)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
            if (array[i,j]<10)
                System.Console.Write(" ");
        }
        Console.WriteLine();
    }
}

int[,] matrix;
System.Console.WriteLine("Введине размер квадратичной матрицы");
string input = Console.ReadLine();
int n;
bool result = int.TryParse(input, out n);
if (result)
{
    matrix = new int[n, n];
    FillBagelArray(matrix);
    PrintMatrix(matrix);
}
else Console.WriteLine("Что то пошло не так, попробуйте еще раз");