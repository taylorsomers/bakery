using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakedGoods.Models;

namespace BakedGoods.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_CreateBreadObject_BreadObject()
    {
      Bread bread = new Bread(1);
      Assert.AreEqual(1, bread.OrderAmount);
    }

    [TestMethod]
    public void BreadPrice_CalculateBreadPrice_BreadPrice()
    {
      Bread bread = new Bread(3);
      Assert.AreEqual(10, bread.BreadPrice());
    }

    [TestMethod]
    public void BreadPrice_CalculateBreadPriceWhenOrderAmountNotDivisibleByThree_BreadPrice()
    {
      Bread bread = new Bread(4);
      Assert.AreEqual(15, bread.BreadPrice());
    }
  }
}