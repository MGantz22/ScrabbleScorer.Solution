using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;
using System.Collections.Generic; 
using System;

namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class Scorer
  {
  [TestMethod]
  public void ScorerConstructor_CreateInstanceofScorer_Scorer()
  {
    Scorer newScorer = new Scorer();
    Assert.AreEqual(typeof(Scorer), newScorer.GetType());
  }

  [TestMethod]
  {

  }

  }
}