/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowSecNum(num);

int ShowSecNum(int num)
{
    int n1 = num % 100;
    int n2 = n1 / 10;
    return n2;    
}

    Console.WriteLine("Current number is " + num + " second digit is "+ ShowSecNum(num));