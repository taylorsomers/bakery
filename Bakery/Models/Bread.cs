using System;
using System.Collections.Generic;

namespace BakedGoods
{
  public class Bread
  {
    public int OrderAmount {get; set;}
    public int Price {get; set;}
    public Bread(int orderAmount, string breadType)
    {
      OrderAmount = orderAmount;
      Price = BreadPrice(orderAmount);
      Price = BreadType(breadType);
    }
    public int BreadPrice()
    {
      int discountMultiple = (int)(OrderAmount / 3);
      int discount = discountMultiple * 5;
      int breadPrice = (OrderAmount * 5) - discount;
      Price = breadPrice;
    }
    public int BreadType(string breadType)
    {
      if (breadType == "french")
      {
        Price = Price * 2;
      }
    }
  }
}