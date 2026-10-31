public static class Rec
{
    public static int DigitSum(int n)
    {
        // Базовый случай: если число однозначное, возвращаем его
        if (n < 10)
        {
            return n;
        }
        return (n % 10) + DigitSum(n / 10);
    }

    public static long Pow(int x, int n)
    {
        // Базовый случай: любая степень 0 равна 1
        if (n == 0)
        {
            return 1;
        }
        return x * Pow(x, n - 1);
    }
}