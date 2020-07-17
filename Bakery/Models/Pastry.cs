using System;
using System.Collections.Generic;

namespace BakedGoods
{
  public class Pastry
  {
    public int OrderAmount {get; set;}
    public Pastry(int orderAmount)
    {
      OrderAmount = orderAmount;
    }
    public int PastryPrice()
    {
      int discountMultiple = (int)(OrderAmount / 3);
      int pastryPrice = (OrderAmount * 2) - discountMultiple;
      return pastryPrice;
    }
  }
}