// Задача 1: Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями
// y = k1*x + b1, y = k2*x + b2; значения b1, k1, b2, k2 задаются пользователем.

// b1=2, k1=5, b2=4, k2=9 -> (-0.5; 5.5)

// Console.WriteLine("Введите b1:");
// int bLine1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите k1:");
// int kLine1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите b2:");
// int bLine2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите k2:");
// int kLine2 = Convert.ToInt32(Console.ReadLine());

// string Perecechenie (double b1, double k1, double b2, double k2)
// {
//     double xPeres = (double)(b2 - b1) / (k1 - k2);
//     double yPeres = k1* xPeres + b1;
//     string result = "" + xPeres + "; " + yPeres;
//     return result;
// }
// Console.WriteLine($"{Perecechenie(bLine1, kLine1, bLine2, kLine2)}");
// Perecechenie(bLine1, kLine1, bLine2, kLine2);



// Задача 2: Показать треугольник Паскаля. Сделать вывод в виде равнобедренного треугольника.
// ДЗ по выводу не сделано, не смогла.


int[,] CreateTriangle(int size)
{
    int[,] triangle = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for (int i = 2; i < size; i++)
    {
        for (int j = 1; j < i; j++)
        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
    return triangle;
}

void PrintMatrix(int[,] triangle)
{
    for (int i = 0; i < triangle.GetLength(0); i++) 
    {
        for (int j = 0; j <= (triangle.GetLength(1) - i); j++) /*создаем после каждой строки triangle.GetLength(1) - i отступы от левой стороны консоли. Чем ниже строка, тем меньше отсуп.*/
        {
            Console.Write("  ");
        }
        for (int j = 0; j <= i; j++)
        {
            Console.Write("  "); /* создание пробелов мж элементами треугольника*/
            Console.Write($"{triangle[i, j]}" + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] triangle = CreateTriangle(10);
PrintMatrix(triangle);


