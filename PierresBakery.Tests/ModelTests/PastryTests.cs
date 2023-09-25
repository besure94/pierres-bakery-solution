using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastryConstructor_Pastry()
    {
      Pastry newPastry = new Pastry(4);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void PastryConstructor_ReturnsNumberOfPastries_Int()
    {
      Pastry newPastry = new Pastry(4);
      int result = newPastry.Pastries;
      Assert.AreEqual(4, result);
    }
  }
}