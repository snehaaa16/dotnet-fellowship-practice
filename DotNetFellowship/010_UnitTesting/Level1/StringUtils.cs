using System;
using System.Linq;
namespace _010_UnitTesting;
public class StringUtils
{
    public string Reverse(string str)
    {
        if (str == null) return null;
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
    public bool IsPalindrome(string str)
    {
        if (string.IsNullOrEmpty(str)) return true;
        string reversed = Reverse(str);
        return str.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }
    public string ToUpperCase(string str)
    {
        return str?.ToUpper();
    }
}
