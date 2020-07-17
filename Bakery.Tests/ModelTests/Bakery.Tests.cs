using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakedGoods;

namespace BakedGoods.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_CreateBreadOrderObject_BreadOrderObject()
    {
    Bread bread = new Bread(1);
    Assert.AreEqual(1, bread.OrderAmount);
    }
  }
}