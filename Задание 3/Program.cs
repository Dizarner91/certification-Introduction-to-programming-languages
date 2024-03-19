using System;

class Program
{
    static void Main(string[] args)
    {
        // Произвольный массив
        int[] array = { 1, 2, 3, 4, 5 };

        // Вызов рекурсивной функции для вывода элементов массива с конца
        PrintArrayReversed(array, array.Length - 1);
    }

    static void PrintArrayReversed(int[] array, int index)
    {
        // Базовый случай: если индекс стал меньше 0, то завершаем рекурсию
        if (index < 0)
            return;

        // Выводим элемент массива с текущим индексом
        Console.WriteLine(array[index]);

        // Рекурсивный вызов функции с уменьшенным на единицу индексом
        PrintArrayReversed(array, index - 1);
    }
}

