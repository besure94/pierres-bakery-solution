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
    public void Pastry_ReturnsNumberOfPastries_Int()
    {
      Pastry newPastry = new Pastry(4);
      int result = newPastry.Quantity;
      Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void Pastry_SetsValueOfPastries_Int()
    {
      Pastry newPastry = new Pastry(4);
      int newQuantity = 8;
      newPastry.Quantity = newQuantity;
      Assert.AreEqual(newQuantity, newPastry.Quantity);
    }

    [TestMethod]
    public void GetPastryCost_ReturnsPastryCostForOrder_Int()
    {
      Pastry numberOfPastries = new Pastry(8);
      int orderTotal = numberOfPastries.GetPastryCost();
      Assert.AreEqual(12, orderTotal);
    }
  }
}