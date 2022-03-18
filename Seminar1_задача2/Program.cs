Console.Write("Введите первое целое число: ");

int value1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");

int value2 = Convert.ToInt32(Console.ReadLine());

int kvadrat_value2 = value2 * value2;

if(kvadrat_value2 == value1)
{
Console.WriteLine("Квадрат второго числа соответствует первому");
}
else
{
    Console.WriteLine("Искомых соответствий не выявлено");
}