using System;
using System.Linq;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a word");
            string s = Console.ReadLine();
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
