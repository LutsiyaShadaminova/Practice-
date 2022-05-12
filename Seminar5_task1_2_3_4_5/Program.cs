/* задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9; 9]. 
Найдите сумму отрицательных и положительных элементов массива.

int [] a = new int[12];
int pos = 0;
int neg = 0;
for (int i = 0; i < 12; i++)
{
    a[i] = new Random().Next(-9, 10);
    if (a[i] > 0)
    {
        pos = a[i] + pos; 
    } 
    else
    {
        neg = neg + a[i];
    }  
    Console.WriteLine(a[i]);     
}
Console.WriteLine($"pos is {pos} neg is {neg}");   
*/

/* Задача 2: Напишите программу замену элементов массива: 
положительные элементы замените на соответствующие отрицательные и наоборот.

int [] a = new int[12];
for (int i = 1; i < 12; i++)
{
    a[i] =  new Random().Next(-9, 10);
    Console.Write(a[i] + " ");     
}
Console.WriteLine();

for (int i = 0; i < 12; i++)
{
    Console.Write((a[i]*(-1)) + " ");   
}
*/


/* Задача 3: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.*/

// int [] a = new int[12];
// int tumbler = 0;
// for (int i = 0; i < 12; i++)
// {
//     a[i] = new Random().Next(1, 20);
//     Console.Write(a[i] + " "); 
// }    
// Console.WriteLine();

// Console.WriteLine("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < 12; i++)
// {
//     if (a[i] == num)
//     {
//         Console.WriteLine("Yes "); 
//         tumbler = 1;
//         break;
//     } 
// }
// if (tumbler == 0) 
// {
//     Console.WriteLine("No");
// }     


/* Задача 4: Задайте одномерный массив из 123 случайных чисел. 
Найдите кол-во элементов массива, значения которых лежат в отрезке [10, 99].*/

int [] a = new int[123];
int count = 0;
for (int i = 0; i < 123; i++)
{
    a[i] = new Random().Next(1, 1000);
    if (a[i] < 100 && a[i] > 9)
    {
        count++;   
    }     
}    
Console.WriteLine(count); 

/* Задача 5: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве */

// Мой вариант:

// int [] a = {1, 2, 3, 4, 5, 6, 7, 8, 9};
// a[0] = 10;
// Console.WriteLine(a[4]);

// int count = 0;
// for (int i = 0; i < 10; i++)
// {
//     if (a[i] >= 1 && a[i] <= 9)
//     {
//         Proizv = a[]
//         count++;   
//     }     
// }    
// Console.WriteLine(count); 

// Вариант группы:

// Console.WriteLine("Введите длину массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] a = new int [num];

// int dlina = 1;
// if (num % 2 == 0)
// {
//     dlina = 0;
// }

// int[] b = new int [(num / 2) + dlina];

// for (int i = 0; i < num; i++)
// {
//     a[i] = i + 1;
//     Console.Write(a[i] + " ");
// }
//  Console.WriteLine();

//  for (int i = 0; i < ((num / 2) + dlina); i++)
//  {
//     b[i] = a[i] * (a[num - i -1]);
//     if (i == num - i - 1)
//     {
//         b[i] = a[i];
//     }
//     Console.Write(b[i] + " ");
//  }
