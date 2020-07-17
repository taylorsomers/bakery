using System;
using System.Collections.Generic;

namespace BakedGoods
{
  public class Bread
  {
    public int OrderAmount {get; set;}
    public Bread(int orderAmount)
    {
      OrderAmount = orderAmount;
    }
    public int BreadPrice()
    {
      int discountMultiple = (int)(OrderAmount / 3);
      int discount = discountMultiple * 5;
      int breadPrice = (OrderAmount * 5) - discount;
      return breadPrice;
    }
  }

  public class Pastry
  {
    public int OrderAmount {get; set;}
    public Pastry(int orderAmount)
    {
      OrderAmount = orderAmount * 2;
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