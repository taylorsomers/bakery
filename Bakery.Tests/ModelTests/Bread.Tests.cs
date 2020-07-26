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
      int orderAmount = 1;
      string breadType = "french";

      Bread bread = new Bread(orderAmount, breadType);

      int result = bread.OrderAmount;

      Assert.AreEqual(orderAmount, bread.OrderAmount);
    }

    [TestMethod]
    public void BreadPrice_CalculateBreadPrice_BreadPrice()
    {
      int orderAmount = 3;
      string breadType = "french";
      
      Bread bread = new Bread(orderAmount, breadType);

      int result = bread.BreadPrice();

      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void BreadPrice_CalculateBreadPriceWhenOrderAmountNotDivisibleByThree_BreadPrice()
    {
      int orderAmount = 4;
      string breadType = "french";
      
      Bread bread = new Bread(orderAmount, breadType);

      int result = bread.BreadPrice();

      Assert.AreEqual(15, result);
    }

    [TestMethod]
    public void BreadConstructor_AddsPriceToInstanceOfBreadClass_Price()
    {
      int orderAmount = 5;
      string breadType = "french";

      Bread bread = new Bread(orderAmount, breadType);

      int result = bread.Price;

      Assert.AreEqual(20, result);
    }
  }
}