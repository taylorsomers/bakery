using System;
using System.Collections.Generic;
using BakedGoods;

class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery! We are very happy to serve you today. At Pierre's we offer bread loaves and pastries, both freshly made to order. To get started, please enter the number of bread loaves you would like to order: ");
    string breadString = Console.ReadLine();
    int breadAmount = int.Parse(breadString);
    List<int> orderList = new List<int> {};
    Bread bread = new Bread(breadAmount);
    if (bread.OrderAmount < 0)
    {
      Console.WriteLine("We cannot process orders for negative amounts of bread. Perhaps you should consult a theoretical physicist about such a request?");
    }
    else
    {
      orderList.Add(breadAmount);
    }
    Console.WriteLine("Great! Now please enter the number of pastries you would like to order: ");
    string pastryString = Console.ReadLine();
    int pastryAmount = int.Parse(pastryString);
    Pastry pastry = new Pastry(pastryAmount);
    if (pastry.OrderAmount < 0)
    {
      Console.WriteLine("We cannot process orders for negative numbers of pastries. Perhaps you should consult a theoretical physicist about such a request?");
    }
    else
    {
      orderList.Add(pastryAmount);
    }
    Console.WriteLine(orderList[1]);
    Main();
  }
}