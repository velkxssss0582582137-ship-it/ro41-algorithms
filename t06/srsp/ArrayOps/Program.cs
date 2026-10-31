using System;

class Program
{
    static void PrintArray(int[] a)
    {
        Console.Write("{");
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i]);
            if (i < a.Length - 1) Console.Write(", ");
        }
        Console.WriteLine("}");
    }

    static void ProcessArray(int[] original, int x)
    {
        // Создаем копию массива для тестов, чтобы исходный массив не менялся до вывода
        int[] a = new int[original.Length];
        Array.Copy(original, a, original.Length);

        Console.Write("Исходный массив: ");
        PrintArray(a);

        Console.WriteLine($"Сумма: {ArrayOps.Sum(a)}");
        Console.WriteLine($"Индекс минимума: {ArrayOps.IndexOfMin(a)}");
        Console.WriteLine($"Элементов больше {x}: {ArrayOps.CountGreater(a, x)}");

        ArrayOps.Reverse(a);
        Console.Write("Массив после Reverse: ");
        PrintArray(a);
        Console.WriteLine();
    }

    static void Main()
    {
        int x = 2;
        ProcessArray(new int[] { 4, 1, 7, 3, 9 }, x);
        ProcessArray(new int[] { 5 }, x);
        ProcessArray(new int[] { -2, -7, -4 }, x);
        ProcessArray(new int[] { 2, 2, 2 }, x);
    }
}