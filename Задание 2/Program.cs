using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод значений m и n
        Console.Write("Введите значение m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        // Вызов функции Аккермана и вывод результата
        int result = AckermannFunction(m, n);
        Console.WriteLine($"Результат функции Аккермана для m={m} и n={n} равен {result}");
    }

    static int AckermannFunction(int m, int n)
    {
        // Проверяем, если значения m и n превышают пороговые значения
        if (m > 3)
            return n + 1;
        else if (m == 0)
            return n + 1;
        else if (n == 0)
            return AckermannFunction(m - 1, 1);
        else
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}

