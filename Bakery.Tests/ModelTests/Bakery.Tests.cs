using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakedGoods;

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
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_CreatePastryObject_PastryObject()
    {
      Pastry pastry = new Pastry(1);
      Assert.AreEqual(1, pastry.OrderAmount);
    }
  }
}