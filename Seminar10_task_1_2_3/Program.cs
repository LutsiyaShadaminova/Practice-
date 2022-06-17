// Задача 1: Напишите программу, которая на вход принимает два числа и выдает
//  первые N чисел, для которых каждое следующее равно сумме двух предыдущих.


// int Fibonachi(int startNum1, int startNum2, int size)
// {
//     if (size == 1) return startNum1;
//     if (size == 2) return startNum2;
//     else return Fibonachi(startNum1, startNum2, size - 1) + Fibonachi(startNum1, startNum2, size - 2);
// }

// int num1 = 0;
// int num2 = 1;
// int col = 5;

// for (int i = 1; i <= col; i++)
// {
//     Console.Write(Fibonachi(num1, num2, i) + " ");
// }


// Задача 2: В некотором машинном алфавите имеются четыре буквы "а", "и", "с", "в". Покажите все слова,
// состоящие из n букв, которые можно построить из букв этого алфавита.

// void PrintWords(string alf, int lengthWord, string currentWord)
// {
//     if (lengthWord == 0)
//     {
//         Console.WriteLine(currentWord);
//     }
//     else
//     {
//         for (int i = 0; i < alf.Length; i++)
//         {
//             PrintWords(alf, lengthWord - 1, currentWord + alf[i]);
//         }
//     }
// }
// PrintWords("ABC", 3, "");

// Задача ДЗ: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел (без разделителя).
//  В массиве data хранится информация о количестве бит, которые занимают числа из массива info. 
// Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.

// Комментарий: первое число занимает 2 бита (01 -> 1); второе число занимает 3 бита (111 -> 7);
// третье число занимает 3 бита (000 -> 0; четвёртое число занимает 1 бит (1 -> 1)

// Пример:
// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }

// выходные данные:
// 1, 7, 0, 1


int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int[] array = Massiv(data, info);


int[] Massiv(int[] binary, int[] digits)
{
    int[] result = new int[digits.Length];
    int binaryposition = 0;

    for (int pos = 0; pos < digits.Length; pos++)
    {
        int number = 0;
        int pow = 0;
        for (int i = digits[pos] - 1; i >= 0; i--)
        {
            number = number + binary[binaryposition + i] * (int)Math.Pow(2, pow);
            pow++;
        }
        Console.Write(number + " ");
        binaryposition += digits[pos];
        result[pos] = number;
    }
    return result;
}


