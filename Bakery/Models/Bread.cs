using System;
using System.Collections.Generic;

namespace BakedGoods
{
  public class Bread
  {
    public int OrderAmount {get; set;}
    public int Price {get; set;}
    public Bread(int orderAmount)
    {
      OrderAmount = orderAmount;
      Price = price;
    }
    public int BreadPrice()
    {
      int discountMultiple = (int)(OrderAmount / 3);
      int discount = discountMultiple * 5;
      int breadPrice = (OrderAmount * 5) - discount;
      Bread.Price = breadPrice.BreadType();
    }
    public int BreadType(string breadType)
    {
      if (breadType == "french")
      {
        Bread.Price = bread.Price * 2;
      }
    }
  }
}