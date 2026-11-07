using System;

class Program
{
    static void Main()
    {
        string[] testStrings = {
            "",
            "    ",
            " a  b ",
            "А роза упала на лапу Азора",
            "Ахметов Ерлан"
        };

        Console.WriteLine("=== ТЕСТИРОВАНИЕ МЕТОДОВ TEXTTOOLS ===");
        
        foreach (var s in testStrings)
        {
            string displayStr = string.IsNullOrEmpty(s) ? "<пусто>" : $"\"{s}\"";
            Console.WriteLine($"\nВход: {displayStr}");
            
            int wordCount = TextTools.CountWords(s);
            Console.WriteLine($"  CountWords: {wordCount}");

            bool isPal = TextTools.IsPalindrome(s);
            Console.WriteLine($"  IsPalindrome: {isPal}");

            string initials = TextTools.Initials(s);
            Console.WriteLine($"  Initials: \"{initials}\"");

            string repeated = TextTools.Repeat(s, 2);
            Console.WriteLine($"  Repeat(s, 2): \"{repeated}\"");
        }
    }
}