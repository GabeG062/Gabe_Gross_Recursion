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
            bool palindrome = true;
            string[] letters = s.Select(c => c.ToString()).ToArray();
            if (s.Length > 1)
            {
                return PrintPalindrome(s.Substring(1));
            }
            if (string.IsNullOrEmpty(s))
            {
                return palindrome;
            }
            else if (s.Length == 1)
            {
                return palindrome;
            }
            else if (letters.Length % 2 == 0)
            {
                int split = letters.Length / 2;
                string[] firstHalf = letters.Take(split).ToArray();
                string[] secondHalf = letters.Skip(split).ToArray();
                if (firstHalf.SequenceEqual(secondHalf))
                {
                    return palindrome;
                }
                else
                {
                    palindrome = false;
                    return palindrome;
                }
            }
            else if (letters.Length % 2 == 1)
            {
                int split = letters.Length / 2;
                string [] evenSplit = letters.Where((value, index) => index != split).ToArray();
                split = evenSplit.Length / 2;
                string[] firstHalf = evenSplit.Take(split).ToArray();
                string[] secondHalf = evenSplit.Skip(split).ToArray();
                if (firstHalf.SequenceEqual(secondHalf))
                {
                    return palindrome;
                }
                else
                {
                    palindrome = false;
                    return palindrome;
                }
            }
            
            
            return palindrome;
        }
    }
}
