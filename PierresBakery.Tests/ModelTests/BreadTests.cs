using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBreadConstructor_Bread()
    {
      Bread newBread = new Bread(3);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void Bread_ReturnsLoaves_Int()
    {
      Bread newBread = new Bread(3);
      int result = newBread.Loaves;
      Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void Bread_SetsValueOfLoaves_Void()
    {
      Bread newBread = new Bread(3);
      int newLoaves = 10;
      newBread.Loaves = newLoaves;
      Assert.AreEqual(newLoaves, newBread.Loaves);
    }

    [TestMethod]
    public void GetBreadCost_ReturnsBreadCostForOrder_Int()
    {
      Bread numberOfLoaves = new Bread(6);
      int orderTotal = numberOfLoaves.GetBreadCost();
      Assert.AreEqual(20, orderTotal);
    }
  }
}