using System;
using System.Collections.Generic;

namespace BakedGoods
{
  public class Bread
  {
    public int breadPrice {get; set;}
    public int OrderAmount {get; set;}
    public Bread(int orderAmount)
    {
      OrderAmount = orderAmount;
    }
    public int BreadPrice()
    {
      int discountMultiple = ((int)(OrderAmount / 3)) * 5;
      int breadPrice = (OrderAmount * 5) - discountMultiple;
      return breadPrice;
    }
  }
}