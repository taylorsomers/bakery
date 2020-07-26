using System;
using System.Collections.Generic;

namespace BakedGoods.Models
{
  public class Bread
  {
    public int Price {get; set;}
    public int OrderAmount {get; set;}
    public Bread(int orderAmount)
    {
      OrderAmount = orderAmount;
      Price = (this).BreadPrice();
      Price = 70;
    }
    public int BreadPrice()
    {
      int discountMultiple = ((int)(OrderAmount / 3)) * 5;
      int breadPrice = (OrderAmount * 5) - discountMultiple;
      return breadPrice;
    }
  }
}