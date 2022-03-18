Console.Write("Введите натуральное целое число: ");

int n = Convert.ToInt32(Console.ReadLine());

if(n % 2 == 0)
{
    Console.Write("Является ли данное число четным: да");
}
else
{
    Console.Write("Является ли данное число четным: нет");
}