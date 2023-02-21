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
    public void AnagramWordConstructor_CreatesInstanceOfMixedWord_MixedWord()
    {
      AnagramWord newWord = new AnagramWord();
      Assert.AreEqual(typeof(AnagramWord), newWord.GetType());
    }
  }
}