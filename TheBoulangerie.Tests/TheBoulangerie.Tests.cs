using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System; 
using TheBoulangerie.Models;

namespace TheBoulangerie.Tests
{
  [TestClass]
  public class TheBoulangerieTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(2); 
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void BreadConstructor_ReturnsQuantity_int()
    {
      int breadAmount = 5; 
      Bread newBread2 = new Bread(breadAmount);
      int result = newBread2.BreadAmount; 
      Assert.AreEqual(breadAmount, result);
    }

  }
}