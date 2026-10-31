public static class ArrayOps
{
    public static int Sum(int[] a)
    {
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }
        return sum;
    }

    public static int IndexOfMin(int[] a)
    {
        int minIndex = 0;
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] < a[minIndex])
            {
                minIndex = i;
            }
        }
        return minIndex;
    }

    public static int CountGreater(int[] a, int x)
    {
        int count = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > x)
            {
                count++;
            }
        }
        return count;
    }

    public static void Reverse(int[] a)
    {
        for (int i = 0; i < a.Length / 2; i++)
        {
            int temp = a[i];
            a[i] = a[a.Length - 1 - i];
            a[a.Length - 1 - i] = temp;
        }
    }
}