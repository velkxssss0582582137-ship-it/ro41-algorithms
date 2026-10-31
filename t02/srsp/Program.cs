using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число n (n >= 0): ");
        string input = Console.ReadLine()!;

        if (!long.TryParse(input, out long n) || n < 0)
        {
            Console.WriteLine("Ошибка: некорректный ввод. Ожидается целое неотрицательное число.");
            return;
        }

        long temp = n;
        long sum = 0;
        long count = 0;

        do
        {
            long digit = temp % 10;
            sum += digit;
            count++;
            temp /= 10;
        } while (temp > 0);

        Console.WriteLine($"Число: {n}");
        Console.WriteLine($"Сумма цифр: {sum}");
        Console.WriteLine($"Количество цифр: {count}");
    }
}