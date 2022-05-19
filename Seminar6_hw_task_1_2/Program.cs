// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int size = Convert.ToInt32(Console.ReadLine());
int [] mas = new int [size];
int count = 0;

for (int i = 0; i < size; i++)
{
    mas[i] = Convert.ToInt32(Console.ReadLine());

    if (mas[i] > 0)
    {
        count++;
    }
    
}
Console.Write(count);


// Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. 
// Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями.

// 3, 4 ->
// 1 1 1 1
// 1 0 0 1
// 1 1 1 1

// int [,] matrix = new int [3, 4];
// for (int i = 0; i < 3; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         if(i == 1 && j < 3 && j > 0)  
//         {
//             matrix[i, j] = 0;
//             Console.Write(matrix[i, j] + " ");
//         }  

//         else
//         {
//             matrix[i, j] = 1;
//             Console.Write(matrix[i, j] + " ");
//         }  
//     }
//     Console.WriteLine(); 
// }