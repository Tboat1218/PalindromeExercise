using System;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            string reversedWord = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }

            return word.ToLower() == reversedWord.ToLower();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome Exercise");
        }
    }
}