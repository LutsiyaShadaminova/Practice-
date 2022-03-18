Console.Write("Введите первое целое число: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");

int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье целое число: ");

int c = Convert.ToInt32(Console.ReadLine());

if(a > b && a > c)
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(a);
}
if(b > a && b > c)
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(b);
}
if(c > a && c > b)
{
    Console.Write("Максимальное число: ");
    Console.WriteLine(c);
}