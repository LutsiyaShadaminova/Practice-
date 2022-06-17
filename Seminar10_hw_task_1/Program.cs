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

