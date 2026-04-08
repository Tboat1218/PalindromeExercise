using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            WordSmith wordSmith = new WordSmith();

            Console.WriteLine(wordSmith.IsAPalindrome("racecar"));  // True
            Console.WriteLine(wordSmith.IsAPalindrome("hello"));    // False
            Console.WriteLine(wordSmith.IsAPalindrome("madam"));    // True
        }
    }
}
