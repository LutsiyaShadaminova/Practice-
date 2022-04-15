/*Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16

Console.Write("Введите целое число: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int B = Convert.ToInt32(Console.ReadLine());

Kvadrat(A, B);

int Kvadrat(int A, int B)
{
    int result = 1;
    for(int i = 1; B >= i; i++)
    {
        result = result*A;
    }
    return result;
}

Console.WriteLine($"{A} в степени {B} равно {Kvadrat(A,B)}");
*/


/*Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12

Console.Write("Введите целое число: ");
int A = Convert.ToInt32(Console.ReadLine());

int Sum(int A)
{
    int result = 0;

    while(A > 0)
    {
        int num = A % 10;
        result = result + num;
        A = A / 10;
    }
    return result;
}
Console.WriteLine($"Сумма чисел числа {A} равна {Sum(A)}");
*/

/*Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void bitArray()
{
    int [] a = new int[8];
    for(int i = 0; i < 8; i++)
    {
        a[i] = new Random().Next(0,99);
        Console.Write(a[i] + " ");
    }
}

bitArray();