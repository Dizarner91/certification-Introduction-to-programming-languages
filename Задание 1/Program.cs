using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод значений M и N
        Console.Write("Введите значение M: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        // Вызов рекурсивной функции для вывода чисел
        PrintNaturalNumbers(m, n);
    }

    static void PrintNaturalNumbers(int m, int n)
    {
        // Базовый случай: если m больше n, то завершаем рекурсию
        if (m > n)
            return;

        // Выводим текущее значение m
        Console.WriteLine(m);

        // Рекурсивный вызов функции с увеличенным на единицу m
        PrintNaturalNumbers(m + 1, n);
    }
}

