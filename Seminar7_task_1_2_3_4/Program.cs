// 1. Задайте двумерный массив размером m x n, заполненный случайнами целыми числами.

// void Massiv1(int m, int n)
// {
//     int[,] a = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             a[i, j] = new Random().Next(10, 99);
//             Console.Write($"{a[i, j]}" + " " );
//         } 
//         Console.WriteLine();       
//     }

// }
// Massiv1 (3, 3);

// 2. Задайте двумерный массив размером m x n, каждый элемент в массиве находится по формуле: Аmn = m + n.
// Выведите полученный массив на экран.

// void Massiv2(int m, int n)
// {
//     int[,] a = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             a[i, j] = i + j;
//             Console.Write($"{a[i, j]}" + " ");
//         }
//         Console.WriteLine();
//     }

// }
// Massiv2(3, 3);

// 3. Задайте двумерный массив. Найдите элементы, у которых оба индекса четные и замените эти элементы на их квадраты.

// void Massiv3(int m, int n)
// {
//     int[,] a = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             a[i, j] = new Random().Next(1, 5);
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 a[i, j] = a[i, j] * a[i, j];        
//             }
//             Console.Write($"{a[i, j]}" + " ");
//         }
//         Console.WriteLine();
//     }
// }
// Massiv3(3, 3);

// 4. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1, 1) и т.д.

void Massiv4(int m, int n)
{
    int sum = 0;
    int[,] a = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            a[i, j] = new Random().Next(1, 5);
            if (i  == j)
            {
                sum = sum + a[i, j];        
            }
            Console.Write($"{a[i, j]}" + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("The sum is: " + sum);
}
Massiv4(3, 3);