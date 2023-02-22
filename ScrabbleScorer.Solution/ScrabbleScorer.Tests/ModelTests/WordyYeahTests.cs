using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;
using System.Collections.Generic;

namespace ScrabbleScorer.Tests

{
  [TestClass]
  public class WordyYeah
  {
  [TestMethod]
  public void ScorerConstructor_CreateInstanceofScorer_Scorer()
  {
    WordyYeah newTile = new WordyYeah();
    Assert.AreEqual(typeof(WordyYeah), newTile.GetType());
  }
  [TestMethod]
    public void ScorerConstructor_ReturnValueOfASingleChar_Int()
  {
    WordyYeah newTile = new WordyYeah();
    char input = 'A';
    int result = WordyYeah.LetterScore(input);
    Assert.AreEqual(1, result);
  }

  }
}