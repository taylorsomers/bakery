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
      int OrderAmount = orderAmount;
    }
    public int BreadPrice()
    {
      int discountMultiple = (int)(OrderAmount / 3);
      int discount = discountMultiple * 5;
      int breadPrice = (OrderAmount * 5) - discount;
      return breadPrice;
    }
  }
}