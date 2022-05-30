// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// void Massiv1(int m, int n)
// {
//     double[,] a = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             a[i, j] = Math.Round(new Random().Next(-9, 10) + new Random().NextDouble(),1);
//             Console.Write($"{a[i, j]}" + " ");
//         }
//         Console.WriteLine();
//     }
// }
// Massiv1(3, 4);

// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение
//  этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

void CreateRandomMatrix1(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 5);
            Console.Write($"{matrix[i, j]}" + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    Console.Write("Введите 1ю позицию элемента: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите 2ю позицию элемента: ");
    int num2 = Convert.ToInt32(Console.ReadLine());


    for (int i = 0; i < matrix.GetLength(0); i++)        
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (num1 == i && num2 == j)
            {
                matrix[i, j] = matrix[num1, num2];
                Console.WriteLine("Данной позиции соответствует число:" + matrix[i, j]);
            }

            if (num1 >= m || num2 >= n)
            {
                if (num1 > m || num2 > n)
                {
                    Console.WriteLine("Такой позиции в массиве не существует");
                }
                else
                {
                    Console.WriteLine("Данной позиции соответствует число:" + matrix[i, j]);
                }
                break;
            }
        }
    }

}

CreateRandomMatrix1(3, 4);

// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

//     int[] sumofcolumn = new int[n];
//     double sum = 0;

//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             sumofcolumn[j] = sumofcolumn[j] + matrix[i, j];
//             sum = sumofcolumn[j];
//         }
//         // Console.Write("\n" + $"{sum}" + ", ");
//         Console.Write($"{string.Format("{0:F1}", sum / m)}" + "; " );       
//     }    
// }

// CreateRandomMatrix2(3, 4);

