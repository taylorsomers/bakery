using System;
using System.Collections.Generic;

namespace BakedGoods.Models
{
  public class Pastry
  {
    public int OrderAmount {get; set;}
    public int Price { get; set; }
    public Pastry(int orderAmount)
    {
      OrderAmount = orderAmount;
      Price = this.PastryPrice();
    }
    public int PastryPrice()
    {
      int discountMultiple = this.OrderAmount / 3;
      int pastryPrice = (this.OrderAmount * 2) - discountMultiple;
      return pastryPrice;
    }
  }
}