using System;

class Program
{
    static void Main()
    {
        TestAndPrint(3, 1, 2);
        TestAndPrint(1, 2, 3);
        TestAndPrint(3, 2, 1);
        TestAndPrint(2, 2, 1);
        TestAndPrint(5, 5, 5);
    }

    static void TestAndPrint(int a, int b, int c)
    {
        int originalA = a, originalB = b, originalC = c;

        Order.Sort3(ref a, ref b, ref c);

        Console.WriteLine($"{originalA} {originalB} {originalC} -> {a} {b} {c}");
    }
}

static class Order
{
    public static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }

    public static void Sort3(ref int a, ref int b, ref int c)
    {
        if (a > b)
        {
            Swap(ref a, ref b);
        }
        if (b > c)
        {
            Swap(ref b, ref c);
        }
        if (a > b)
        {
            Swap(ref a, ref b);
        }
    }
}