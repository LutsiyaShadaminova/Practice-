// 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// !!! На семинаре решено чз int  и все задачи интегрированы как один проект. 
// Задача 2 принимает в качестве аргумента массив из Задачи 1 чз Метод чз метод Sweep.

// void Massiv1(int m, int n)
// {
//     int[,] Shifter = new int[m, n];

//     for (int i = 0; i < Shifter.GetLength(0); i++)
//     {
//         for (int j = 0; j < Shifter.GetLength(1); j++)
//         {
//             Shifter[i, j] = new Random().Next(1, 5);
//             Console.Write($"{Shifter[i, j]}" + " ");
//         }
//         Console.WriteLine(); 
//     }
//     Console.WriteLine();

//     for (int i = 0; i < Shifter.GetLength(0); i++)
//     {
//         for (int j = 0; j < Shifter.GetLength(1); j++)
//         {
//             int temp = Shifter[0, j];
//             Shifter[0, j] = Shifter[m - 1, j];
//             Shifter[m - 1, j] = temp;
//             Console.Write($"{Shifter[i, j]}" + " ");
//         }
//         Console.WriteLine(); 
//     }
// }   

// Massiv1(3, 4);

// 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, то программа должна вывести сообщение для пользователя.

// Console.WriteLine("Введите размер квадратной матрицы:");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// if (m != n)
// {
//     Console.WriteLine("Введен неверный размер матрицы");
// }

// void Massiv2(int m, int n)
// {
//     int[,] a = new int[m, n];

//     for (int i = 0; i < a.GetLength(0); i++)
//     {
//         for (int j = 0; j < a.GetLength(1); j++)
//         {
//             a[i, j] = new Random().Next(1, 5);
//             Console.Write($"{a[i, j]}" + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();

//     int temp = 0;
//     int count = 0;

//     for (int i = 0; i < m && count <= (m * n) / 2 + 1; i++)
//     {
//         for (int j = i; j < n; j++)
//         {
//             temp = a[i, j];
//             a[i, j] = a[j, i];
//             a[j, i] = temp;
//             count++;
//         }

//     }
//     for (int i = 0; i < a.GetLength(0); i++)
//     {
//         for (int j = 0; j < a.GetLength(1); j++)
//         {
//             Console.Write($"{a[i, j]}" + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Massiv2(m, n);

// Недорешена!!! Смотреть семинар!
// 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

void Massiv3(int m, int n)
{
    int[,] a = new int[m, n];

    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(1, 5);
            Console.Write($"{a[i, j]}" + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Massiv3(3, 4);

int [,] CrossDeleting (int[,]a)
{
    int minI = 0;
    int minJ = 0;
    int min = a[0, 0];

    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (a[i, j] < min)
            {
                minI = i;
                minJ = j;
            }

            a[minI, i] = 0;
            a[j, minJ] = 0;
            Console.Write($"{a[i, j]}" + " ");
        }

    }

}
int [,] a2 = CrossDeleting (3,3);

//     for (int i = 0; i < a.GetLength(0); i++)
//     {
//         a[minI, i] = 0;
//     }
//     for (int j = 0; j < a.GetLength(1); j++)
//     {
//         a[j, minJ] = 0;
//     }
//     Console.Write($"{a[i, j]}" + " ");
// }


