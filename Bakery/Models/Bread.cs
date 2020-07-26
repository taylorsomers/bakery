using System;
using System.Collections.Generic;

namespace BakedGoods.Models
{
  public class Bread
  {
    public int Price { get; set; }
    public int OrderAmount { get; set; }
    public string Type { get; set; }
    public Bread(int orderAmount, string type)
    {
      OrderAmount = orderAmount;
      Type = type;
      Price = (this).BreadPrice();
    }
    public int BreadPrice()
    {
      int discountMultiple = ((int)(OrderAmount / 3)) * 5;
      int breadPrice = (OrderAmount * 5) - discountMultiple;
      if (this.Type == "marble rye")
      {
        breadPrice = breadPrice * 3;
      }
      else if (this.Type == "sourdough")
      {
        breadPrice = breadPrice * 2;
      }
      return breadPrice;
    }
  }
}