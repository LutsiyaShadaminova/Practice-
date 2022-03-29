﻿/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int n1 = num / 10000;
int n2 = num % 10;
int n3 = num / 1000 % 10;
int n4 = num % 100 / 10;

if(n1 == n2 && n3 == n4)
{
    Console.WriteLine("Данное число является полиндромом: да");
} 
else
{
    Console.WriteLine("Данное число является полиндромом: нет");
}