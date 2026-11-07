using System;

public static class ArrayAlgos
{
    public static bool IsSorted(int[] a)
    {
        if (a == null || a.Length <= 1) return true;
        for (int i = 0; i < a.Length - 1; i++)
        {
            if (a[i] > a[i + 1]) return false;
        }
        return true;
    }
    public static int BubbleSort(int[] a)
    {
        if (a == null || a.Length <= 1) return 0;
        int n = a.Length;
        int comparisons = 0;

        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < n - 1 - i; j++)
            {
                comparisons++;
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
        return comparisons;
    }

    private static int LowerBound(int[] a, int x)
    {
        int lo = 0, hi = a.Length;
        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;
            if (a[mid] >= x)
            {
                hi = mid;
            }
            else
            {
                lo = mid + 1;
            }
        }
        return lo;
    }

    private static int UpperBound(int[] a, int x)
    {
        int lo = 0, hi = a.Length;
        while (lo < hi)
        {
            int mid = lo + (hi - lo) / 2;
            if (a[mid] > x)
            {
                hi = mid;
            }
            else
            {
                lo = mid + 1;
            }
        }
        return lo;
    }

    public static int CountOccurrences(int[] sortedA, int x)
    {
        if (sortedA == null || sortedA.Length == 0) return 0;
        int lb = LowerBound(sortedA, x);
        int ub = UpperBound(sortedA, x);
        return ub - lb;
    }
}