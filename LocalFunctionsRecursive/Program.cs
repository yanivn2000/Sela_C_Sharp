using System;

namespace LocalFunctionsRecursive
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string str = "Hello";
            Console.WriteLine($"String {str} is Palindrom: {IsWordPalindrome(str)}");
            str = "ABNNBA";
            Console.WriteLine($"String {str} is Palindrom: {IsWordPalindrome(str)}");
            str = "ABNNBA1";
            Console.WriteLine($"String {str} is Palindrom: {IsWordPalindrome(str)}");
            str = "ABxxxxxBA";
            Console.WriteLine($"String {str} is Palindrom: {IsWordPalindrome(str)}");
        }

        static bool IsWordPalindrome(string word)
        {
            if (word == null)
                throw new ArgumentNullException(nameof(word));

            if (word.Length < 2)
                return true;

            return IsPalidrome(0, word.Length - 1);

            bool IsPalidrome(int lo, int hi)
            {
                if (lo >= hi)
                    return true;

                if (char.ToUpperInvariant(word[lo]) !=
                    char.ToUpperInvariant(word[hi]))
                    return false;

                return IsPalidrome(lo + 1, hi - 1);
            }
        }
    }
}


