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
      Bread newBread = new Bread(); 
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
  }
}