// с этой задачей не разобралась((

Console.Write("Введите натуральное число: ");

int n = Convert.ToInt32(Console.ReadLine());
int a = 1;

while(n > a && (n % 2) == 0)
{
    Console.WriteLine(n);
    n + 2;
}
