using System;
using System.Collections.Generic;
using BakedGoods.Models;

class Program
{
  static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery! We are very happy to serve you today. At Pierre's we offer bread loaves and pastries, both freshly made to order. Would you like to place an order today? Type Y for Yes or N for No.");
    if (Console.ReadLine().ToLower() == "n")
    {
      Console.WriteLine("Goodbye.");
    }
    else
    {
      Console.WriteLine("Great! Our price per loaf of bread is $5. For every two loaves you order, the third is free! Pastries are $2 per item, and $1 off for every third pastry you order. To get started, how many loaves of bread would you like?");
      string breadString = Console.ReadLine();
      int breadAmount = int.Parse(breadString);
      Console.WriteLine("What type of bread would you like? We offer French, Marble Rye, and Sourdough. (Please enter one of these types with exact spelling.)");
      string breadType = Console.ReadLine().ToLower();
      if (breadType != "french" && breadType != "marble rye" && breadType != "sourdough")
      {
        Console.WriteLine("Sorry, we do not know what type of bread you are requesting. Did you spell it correctly?");
      }
      else
      {
        Bread bread = new Bread(breadAmount, breadType);
        if (bread.OrderAmount < 0)
        {
          Console.WriteLine("We cannot process orders for negative amounts of bread. Perhaps you should consult a theoretical physicist about such a request?");
        }
        Console.WriteLine("Great! Now please enter the number of pastries you would like to order: ");
        string pastryString = Console.ReadLine();
        int pastryAmount = int.Parse(pastryString);
        Console.WriteLine("What type of pastry would you like? We offer Croissant, Quenelle, and Baklava. (Please enter one of these types with exact spelling.)");
        string pastryType = Console.ReadLine().ToLower();
        if (pastryType != "croissant" && pastryType != "quenelle" && pastryType != "baklava")
        {
          Console.WriteLine("Sorry, we do not know what type of pastry you are requesting. Did you spell it correctly?");
        }
        else
        {
        Pastry pastry = new Pastry(pastryAmount, pastryType);
        if (pastry.OrderAmount < 0)
        {
          Console.WriteLine("We cannot process orders for negative numbers of pastries. Perhaps you should consult a theoretical physicist about such a request?");
        }
        int outputPrice = bread.Price + pastry.Price;
        Console.WriteLine("Thank you for your order! Your total comes out to: $" + outputPrice.ToString());
        }
      }
    }
  }
}