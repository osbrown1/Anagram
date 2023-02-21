using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramWordTests
  {
    [TestMethod]
    public void IsAnagramWordConstructor_CreatesInstanceOfAnagramWord_AnagramWord()
    {
      AnagramWord newWord = new AnagramWord();
      Assert.AreEqual(typeof(AnagramWord), newWord.GetType());
    }

    [TestMethod]
    public void IsWord1AnAnagramOfWord2()
    {
      //Arrange
      string userInputedWord1 = "bread";
      string userInputedWord2 = "beard";
      AnagramWord anagramWord = new AnagramWord();
      // Act
      bool result = anagramWord.IsAnagramWord(userInputedWord1, userInputedWord2);
      //Assert
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void SeperateWordsIntoChar()
    {
      string userInputedWord1 = "bread";
      string userInputedWord2 = "beard";
      AnagramWord anagramWord = new AnagramWord();

      char[] word1Chars = userInputedWord1.ToCharArray();
      char[] word2Chars = userInputedWord2.ToCharArray();

      Array.Sort(word1Chars);
      Array.Sort(word2Chars);
      
      CollectionAssert.AreEqual(word1Chars, word2Chars);
    }

  
    
  }
}