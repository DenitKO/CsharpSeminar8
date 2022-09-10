// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

bool DoNotReapete(int[,,] someArray, int digit)
{
    bool repeat = false;
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        for (int j = 0; j < someArray.GetLength(1); j++)
        {
            for (int k = 0; k < someArray.GetLength(2); k++)
            {
                if (someArray[i,j,k] == digit)
                {
                    return repeat=true;
                }
            }
            
        }
    }
    return repeat;
}

void Fill3xArray(int[,,] array)
{
    int rnd = new Random().Next(0, 100);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int k = 0;
            while (k < array.GetLength(2))
            {
                if (!DoNotReapete(array, rnd))
                {
                    array[i, j, k] = rnd;
                    k++;
                }
                else                 
                {
                    rnd = new Random().Next(0, 100);
                }
            }
        }
    }
}

void Print3xArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] martix = new int[2, 2, 2];
Fill3xArray(martix);
Print3xArray(martix);