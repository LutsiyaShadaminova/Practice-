// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int [] a = new int[5];
// int count = 0;

// for (int i = 0; i < 5; i++)
// {
//     a[i] = new Random().Next(99, 999);
//     Console.Write(a[i] + " ");     
// }    

// Console.WriteLine();

// for (int i = 0; i < 5; i++)
// {
//     if (a[i] % 2 == 0)
//     {
//         count++;
//     }    
// }  
// Console.Write(count);  

// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int [] a = new int[4];
// int sum = 0;

// for (int i = 0; i < 4; i++)
// {
//     a[i] = new Random().Next(-6, 9);
//     Console.Write(a[i] + " ");     
// }    

// Console.WriteLine();

// for (int i = 1; i < 4; i+= 2)
// {   
//     sum = sum + a[i]; 
// }
// Console.WriteLine(sum);

// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double [] a = {3, 7, 22, 2, 78};
double max = a[0];
double min = a[0];

for (int i = 1; i < a.Length; i++)
{
    if(a[i] < min)
    {
        min = a[i];
    }
    
    if(a[i] > max)
    {
        max = a[i];
    }
}
// Console.WriteLine("{0}", max - min);
Console.WriteLine($"max - min = {max - min}");