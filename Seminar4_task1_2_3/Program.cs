/* Задача 1: Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

int TotalSum(int A)
{
    int result = 0;
    int i = 1;
    while (i <= A)
    {
        result = result + i;
        i++;
    }
    return result;
}

Console.Write("Введите целое число: ");
int A = Convert.ToInt32(Console.ReadLine());
if(A < 1) Console.WriteLine("Вы ввели ненатуральное число");
else Console.WriteLine($"Сумма чисел от 1 до {A} равна {TotalSum(A)}");
*/

/*Задача 2: Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

void Dlina(int N)
{
    int i = 1;
    while(Math.Abs(N / 10) > 1)
    {
        N = N / 10;
        i++;
    }
    Console.WriteLine("Количество цифр в введенном числе: " + i);
}

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Dlina(num);

*/

/*Задача 3: Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

Вариант 1

int Factorial(int A)
{
    int result = 1;
    for (int i = 1; i <= A; i++)
    {
        result = result*i;
    }
    return result;
}

Вариант 2

int Factorial(int A)
{
    int result = 1;
    int i = 1;
    while (i <= A)
    {
        result = result*i;
        i++;
    }
    return result;
}

Console.Write("Введите целое число: ");
int A = Convert.ToInt32(Console.ReadLine());
if(A < 1) Console.WriteLine("Вы ввели ненатуральное число");
else Console.WriteLine($"Произведение чисел от 1 до {A} равно {Factorial(A)}");
*/

/*Задача 4: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.*/

void bitArray()
{
    int [] a = new int[8];
    for(int i = 0; i < 8; i++)
    {
        a[i] = new Random().Next(0,2);
        Console.Write(a[i] + " ");
    }
}

bitArray();