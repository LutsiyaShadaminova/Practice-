// Задача 1: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать тругольник со сторонами такой длины.

// Console.Write("Введите первое целое число: ");

// int a = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе целое число: ");

// int b = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе целое число: ");

// int c = Convert.ToInt32(Console.ReadLine());

// void Triangle (int a, int b, int c)
// {
//     if(a < b + c && b < a + c && c < a + b)
//     {
//         Console.WriteLine("Да");
//     }
//     else
//     {
//         Console.WriteLine("Нет");
//     }    
// }

// Triangle (a, b, c);


// Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// Console.Write("Введите десятичное число: ");

// int a = Convert.ToInt32(Console.ReadLine());

// Binar(a);

// void Binar (int num)
// {
//     string answer = "";
//     while(num > 0)
//     {
//        answer = Convert.ToString(num % 2) + answer;
//        num = num / 2; 
//     }
//     Console.WriteLine(answer);
// }



// Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Fibonachi (a);

// void Fibonachi (int num)
// {
//     int [] b = new int [num];
//     b [0] = 0;
//     b [1] = 1;
//     Console.Write("0 1 ");

//     for (int i = 2; i < num; i++)
//     {
//        b [i] = b [i-1] + b [i-2];
//        Console.Write(b [i] + " ");
//     }       
// }


// Задача 4: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
// Сгенерировать массив 3 на 4; 

int [,] matrix = new int [3,4];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
