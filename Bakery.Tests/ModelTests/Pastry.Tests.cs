using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakedGoods.Models;

namespace BakedGoods.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_CreatePastryObject_PastryObject()
    {
      Pastry pastry = new Pastry(1);
      Assert.AreEqual(1, pastry.OrderAmount);
    }

    [TestMethod]
    public void PastryPrice_CalculatePastryPrice_PastryPrice()
    {
      Pastry pastry = new Pastry(1);
      Assert.AreEqual(2, pastry.PastryPrice());
    }

    [TestMethod]
    public void PastryPrice_CalculateDiscountedPastryPrice_PastryPrice()
    {
      Pastry pastry = new Pastry(3);
      Assert.AreEqual(5, pastry.PastryPrice());
    }
  }
}