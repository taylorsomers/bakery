using System;
using System.Collections.Generic;

namespace BakedGoods
{
  public class Bread
  {
    public int OrderAmount {get; set;}
    public Bread(int orderAmount)
    {
      OrderAmount = orderAmount * 2;
    }
  }

  public class Pastry
  {

  }
}