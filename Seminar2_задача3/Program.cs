/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если второе число не кратно числу первому, то программа выводит остаток от деления.
*/

Console.Write("Введите первое целое число: ");

int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");

int n2 = Convert.ToInt32(Console.ReadLine());

Kratn(n1, n2);

void Kratn(int n1, int n2)
{
    if(n1 % n2 == 0)
    {
        Console.WriteLine("Yes!");
    }
    else
    {
    Console.WriteLine(n1 % n2);
    }
}

