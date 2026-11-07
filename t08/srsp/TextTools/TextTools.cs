using System;
using System.Text;

public static class TextTools
{
    public static int CountWords(string s)
    {
        if (string.IsNullOrWhiteSpace(s)) return 0;
        string[] words = s.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    public static bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s)) return true;
        
        int left = 0;
        int right = s.Length - 1;
        
        while (left < right)
        {
            while (left < right && char.IsWhiteSpace(s[left])) left++;
            while (left < right && char.IsWhiteSpace(s[right])) right--;
            
            if (left < right)
            {
                if (char.ToLower(s[left]) != char.ToLower(s[right]))
                {
                    return false;
                }
                left++;
                right--;
            }
        }
        return true;
    }

    public static string Initials(string fullName)
    {
        if (string.IsNullOrWhiteSpace(fullName)) return string.Empty;
        
        string[] parts = fullName.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length == 0) return string.Empty;
        
        StringBuilder sb = new StringBuilder();
        foreach (var part in parts)
        {
            if (part.Length > 0)
            {
                sb.Append(char.ToUpper(part[0])).Append(". ");
            }
        }
        return sb.ToString().TrimEnd();
    }

    public static string Repeat(string s, int n)
    {
        if (string.IsNullOrEmpty(s) || n <= 0) return string.Empty;
        
        StringBuilder sb = new StringBuilder(s.Length * n);
        for (int i = 0; i < n; i++)
        {
            sb.Append(s);
        }
        return sb.ToString();
    }
}