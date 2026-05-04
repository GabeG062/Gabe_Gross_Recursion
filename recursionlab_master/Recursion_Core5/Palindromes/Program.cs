using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a word");
            string s = Console.ReadLine();
            s = s.ToLower();
            s = s.Replace(" ", "");
            s = Regex.Replace(s, @"[^\w\d\s]", "");
            bool isTrue = PrintPalindrome(s);
            Console.WriteLine(isTrue);
            
        }

        static bool PrintPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s) || s.Length == 1)
            {
                return true;
            }

            if (s[0] != s[s.Length - 1])
            {
                return false;
            }
            return PrintPalindrome(s.Substring(1, s.Length - 2));
        }
    }
}
