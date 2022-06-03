// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

/* Основной цикл (количество повторений равно количеству элементов массива)
Вложенный цикл (количество повторений, равно количеству элементов массива
минус 1 и минус количество выполненных повторений основного цикла)*/

// int[,] CreateRandomMatrix(int row, int column)
// {
//     int[,] matrix = new int[row, column];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 10);
//             Console.Write($"{matrix[i, j]}" + " ");
//         }
//         Console.WriteLine();
//     }
//     return matrix;
// }

// int[,] Sweep(int[,] matrix)
// {

//     for (int k = 0; k < matrix.GetLength(0); k++)

//     {
//         for (int l = matrix.GetLength(1) - 1; l > 0; l--)

//         {
//             for (int r = 0; r < l; r++)
//             {
//                 if (matrix[k, r] > matrix[k, r + 1])
//                 {
//                     int temp = matrix[k, r];
//                     matrix[k, r] = matrix[k, r + 1];
//                     matrix[k, r + 1] = temp;
//                 }
//             }
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}" + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] matrix = CreateRandomMatrix(4, 4);
// Console.WriteLine();
// PrintMatrix(Sweep(matrix));
// -----------------------------------------------------------

// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// void CreateRandomMatrix2(int m, int n)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(1, 5);
//             Console.Write($"{matrix[i, j]}" + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();

//     int[] sumofrows = new int[m];                         /*Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/      
//                                                           /*Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            sumofrows[i] =  sumofrows[i] + matrix[i, j];          
//         }
//         Console.Write($"{sumofrows[i]}" + "; ");
//     }
//     Console.WriteLine();

//     int minI = 0;
//     for (int i = 0; i < m; i++)
//     {
//         if (sumofrows[i] < sumofrows[minI])
//         {
//             minI = i;
//         }           
//     }
//     Console.Write("Индекс с минимальной суммой элементов:" + (minI)); 

// }

// CreateRandomMatrix2(3, 4);

// -----------------------------------------------------------------------------------------
// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// массив размером 2 x 2 x 2

// 12(0,0,0) 22(0,0,1)
// 75(0,1,0) 31(0,1,1)
// 45(1,0,0) 53(1,0,1)
// 32(1,1,0) 23(1,1,1)

void CreateRandomMatrix3(int m, int n, int l)
{
    int[,,] matrix = new int[m, n, l];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                {
                    matrix[i, j, k] = new Random().Next(10, 99);
                    Console.Write($"{matrix[i, j, k]}" +  " " + $"({i}; {j}; {k})\t");
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}   


CreateRandomMatrix3(2, 2, 2);

// ----------------------------------------------------------------------------------------
// Задача 4: Заполните спирально массив 4 на 4.

// На выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7


// void CreateSpiralMatrix(int m, int n)
// {
//     int[,] matrix = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     int k = 1;
//     int x0 = 0;
//     int xk = m - 1;
//     int y0 = 0;
//     int yk = n - 1;

//     while (k < m * n)
//     {
//         for (int i = x0; i <= xk; i++)
//         {
//             matrix[y0, i] = k++;
//         }
//         y0++;

//         for (int j = y0; j <= yk; j++)
//         {
//             matrix[j, xk] = k++;
//         }
//         xk--;

//         for (int i = xk; i >= x0; i--)
//         {
//             matrix[yk, i] = k++;
//         }
//         yk--;
//         for (int j = yk; j >= y0; j--)
//         {
//             matrix[j, x0] = k++;
//         }
//         x0++;
//     }

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//     Console.WriteLine();
//     }

// }

// CreateSpiralMatrix(4, 4);
