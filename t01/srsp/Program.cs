using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество секунд: ");
        string input = Console.ReadLine()!;

        if (!int.TryParse(input, out int totalSeconds) || totalSeconds < 0)
        {
            Console.WriteLine("Ошибка: некорректный ввод.");
        }
        else
        {
            int hours = totalSeconds / 3600;
            int rem = totalSeconds % 3600;
            int minutes = rem / 60;
            int seconds = rem % 60;
            Console.WriteLine($"Результат: {hours} ч. {minutes} мин. {seconds} сек.");
        }
    }
}