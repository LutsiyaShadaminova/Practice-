// с этой задачей помучилась((, спасибо ребятам помогли

Console.Write("Введите натуральное число: ");

int n = Convert.ToInt32(Console.ReadLine());
int a = 1;

while(n >= a)
{
    if(a % 2 == 0)
    {
        Console.WriteLine(a);
        a++;
    }
    else
    {
        a++;
    }
}
