Console.Write("Введите натуральное число: ");

int n = Convert.ToInt32(Console.ReadLine());
int neg_n = n*(-1);

while(neg_n <= n)
{
    Console.WriteLine(neg_n);
    neg_n++;
}
