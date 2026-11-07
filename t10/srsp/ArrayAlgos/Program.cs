using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== ТЕСТИРОВАНИЕ BUBBLE SORT И IS SORTED ===");
        int[][] bubbleTests = {
            new int[] { },
            new int[] { 5 },
            new int[] { 1, 2, 3, 4, 5 },
            new int[] { 5, 4, 3, 2, 1 },
            new int[] { 3, 1, 3, 2, 3 }
        };

        foreach (var orig in bubbleTests)
        {
            int[] a = (int[])orig.Clone();
            string before = "[" + string.Join(", ", a) + "]";
            bool sortedBefore = ArrayAlgos.IsSorted(a);
            int comps = ArrayAlgos.BubbleSort(a);
            string after = "[" + string.Join(", ", a) + "]";
            bool sortedAfter = ArrayAlgos.IsSorted(a);

            Console.WriteLine($"До: {before} | IsSorted: {sortedBefore}");
            Console.WriteLine($"После: {after} | IsSorted: {sortedAfter} | Сравнений: {comps}");
            Console.WriteLine(new string('-', 40));
        }

        int[] sorted1000 = new int[1000];
        for (int i = 0; i < 1000; i++) sorted1000[i] = i;
        int comps1000 = ArrayAlgos.BubbleSort(sorted1000);
        Console.WriteLine($"Отсортированный массив из 1000 элементов: сравнений = {comps1000} (ожидается 999)\n");

        Console.WriteLine("=== ТЕСТИРОВАНИЕ COUNT OCCURRENCES ===");
        int[] sortedA = { 1, 2, 2, 2, 5, 7 };
        int[] queryValues = { 2, 1, 7, 3, 9 };

        Console.WriteLine("Массив: [" + string.Join(", ", sortedA) + "]");
        foreach (int x in queryValues)
        {
            int count = ArrayAlgos.CountOccurrences(sortedA, x);
            Console.WriteLine($"x = {x} -> вхождений: {count} (ожидается согласно условию)");
        }
    }
}