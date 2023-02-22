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
    int tile1 = 1;
    WordyYeah newTile = new WordyYeah();
    int result = newTile.LetterWin;
    Assert.AreEqual(tile1, result);
  }

  }
}