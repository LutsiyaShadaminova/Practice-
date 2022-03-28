// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

int DelSecNum(int num)
{
    int n1 = (num / 100) * 10;
    int n2 = num % 10;
    return n1 + n2;  
}

    int number = new Random().Next(100, 999);
    Console.WriteLine("Current number is " + number + " two-digit NO is "+ DelSecNum(number));