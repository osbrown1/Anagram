using System.Collections.Generic;
using System;

namespace Anagram.Models
{
  public class AnagramWord // MixedWord
  {
    public bool IsAnagramWord(string userInputedWord1, string userInputedWord2)
    {

      char[] word1Chars = userInputedWord1.ToCharArray();
      char[] word2Chars = userInputedWord2.ToCharArray();

      Array.Sort(word1Chars);
      Array.Sort(word2Chars);

      if (word1Chars != word2Chars)
      {
        return false;
      }
      else
      {
        return true;
      }
    }
  }
}