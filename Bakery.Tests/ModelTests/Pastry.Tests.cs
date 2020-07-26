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
      int orderAmount = 1;
      string pastryType = "croissant";

      Pastry pastry = new Pastry(1, pastryType);

      int result = pastry.OrderAmount;

      Assert.AreEqual(orderAmount, result);
    }

    [TestMethod]
    public void PastryPrice_CalculatePastryPrice_PastryPrice()
    {
      int orderAmount = 1;
      string pastryType = "croissant";
      
      Pastry pastry = new Pastry(orderAmount, pastryType);

      int result = pastry.Price;

      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void PastryPrice_CalculateDiscountedPastryPrice_PastryPrice()
    {
      int orderAmount = 3;
      string pastryType = "croissant";
      
      Pastry pastry = new Pastry(orderAmount, pastryType);

      int result = pastry.Price;

      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void PastryConstructor_AddsPriceToInstanceOfPastryClass_Price()
    {
      int orderAmount = 5;
      string pastryType = "croissant";

      Pastry pastry = new Pastry(orderAmount, pastryType);

      int result = pastry.Price;

      Assert.AreEqual(9, result);
    }
  }
}