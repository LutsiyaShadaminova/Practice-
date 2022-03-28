/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 7 и 23 вводит пользователь.
*/

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первое число: ");
int check1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int check2 = Convert.ToInt32(Console.ReadLine());

Proverka(number, check1, check2);

void Proverka(int number, int check1, int check2)
{
    if(number % check1 == 0 && number % check2 == 0)
    {
        Console.WriteLine("Число " + number + " является кратным " + check1 + " и " + check2);
    }
    else
    {
    Console.WriteLine("Число " + number + " не является кратным " + check1 + " и " + check2);
    }
}


