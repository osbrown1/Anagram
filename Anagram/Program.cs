using System; // new code
using Anagram.Models;
using System.Collections.Generic;
using System.Linq;

namespace Anagram
{
  class Program
  {
    static bool IsAnagramWord(string word1, string word2)
    {
      // Convert the words to character arrays
      char[] word1Chars = word1.ToCharArray();
      char[] word2Chars = word2.ToCharArray();

      // Sort the character arrays
      Array.Sort(word1Chars);
      Array.Sort(word2Chars);

      // Compare the sorted character arrays
      return Enumerable.SequenceEqual(word1Chars, word2Chars);
    }
    static void Main()
    {
      Console.WriteLine("Enter your first word:");
      string word1 = Console.ReadLine();
      Console.WriteLine("Enter your second word");
      string word2 = Console.ReadLine();

      bool result = IsAnagramWord(word1, word2);


      if (result)
      {
        Console.WriteLine($"The words '{word1}' and '{word2}' are anagrams.");
      }
      else
      {
        Console.WriteLine($"The words '{word1}' and '{word2}' are not anagrams.");
      }

      Console.ReadLine();
    }

  }
}

