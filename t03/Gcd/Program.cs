using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        if (!int.TryParse(Console.ReadLine(), out int a) || a < 0)
        {
            Console.WriteLine("Ошибка: некорректный ввод для a.");
            return;
        }

        Console.Write("Введите b: ");
        if (!int.TryParse(Console.ReadLine(), out int b) || b < 0)
        {
            Console.WriteLine("Ошибка: некорректный ввод для b.");
            return;
        }

        if (a == 0 && b == 0)
        {
            Console.WriteLine("Ошибка: а и b не могут быть оба равны нулю.");
            return;
        }

        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }

        Console.WriteLine($"НОД = {a}");
    }
}