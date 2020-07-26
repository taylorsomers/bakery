using System;
using System.Collections.Generic;

namespace BakedGoods.Models
{
  public class Pastry
  {
    public int OrderAmount { get; set;}
    public int Price { get; set; }
    public string Type { get; set; }
    public Pastry(int orderAmount, string pastryType)
    {
      OrderAmount = orderAmount;
      Type = pastryType;
      Price = this.PastryPrice();
    }
    public int PastryPrice()
    {
      int discountMultiple = (int)(this.OrderAmount / 3);
      int pastryPrice = (this.OrderAmount * 2) - discountMultiple;
      return pastryPrice;
    }
  }
}