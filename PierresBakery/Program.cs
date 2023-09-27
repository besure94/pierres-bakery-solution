using System;
using PierresBakery.Models;
using System.Collections.Generic;

namespace PierresBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to Pierre's Bakery, home to the best bread and pastries in town!");
      Console.WriteLine("What can we do for you today?");
      Console.WriteLine("A single loaf of bread costs $5, and a single pastry costs $2.");
      Console.WriteLine("We also offer the following deals:");
      Console.WriteLine("For every 2 loaves of bread you buy, the third loaf is free! For example, two loaves costs $10, three loaves costs $10, four loaves costs $15, and so on...");
      Console.WriteLine("For every 3 pastries you buy, the fourth pastry is free! For example, two pastries costs $4, three pastries costs $6, four pastries costs $6, and so on...");
      Console.WriteLine("Please enter how many loaves of bread you would like to order:");
      string breadLoaves = Console.ReadLine();
      Console.WriteLine("Please enter how many pastries you would like to order:");
      string pastries = Console.ReadLine();
      try
      {
        int breadQuantity = int.Parse(breadLoaves);
        int pastryQuantity = int.Parse(pastries);
        Bread bread = new Bread(breadQuantity);
        Pastry pastry = new Pastry(pastryQuantity);
        if (breadQuantity == 0 && pastryQuantity == 0)
        {
          Console.WriteLine("An empty order will not be accepted! To place an order, please order at least one loaf of bread or pastry.");
          Main();
        }
        else
        {
          ConfirmOrEditOrder(bread, pastry);
        }
      }
      catch
      {
        Console.WriteLine("ERROR: Please only enter numbers! Symbols and alphabetic characters will not be accepted.");
        Console.WriteLine("Please place your order again...");
        Main();
      }
    }

    static void ConfirmOrEditOrder(Bread bread, Pastry pastry)
    {
      Console.WriteLine("Please confirm that your order is correct:");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine($"Bread: {bread.Quantity}");
      Console.WriteLine($"Pastries: {pastry.Quantity}");
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Is that correct? Enter 'yes' to continue, or 'no' to re-enter the amount.");
      string userInput = Console.ReadLine();
      if (userInput == "yes" || userInput == "Yes")
      {
        GetOrderTotal(bread, pastry);
      }
      else
      {
        Console.WriteLine("Please re-enter your order.");
        Console.WriteLine("Please enter the amount of loaves you would like to order:");
        string userBreadOrder = Console.ReadLine();
        Console.WriteLine("Please enter the amount of pastries you would like to order:");
        string userPastryOrder = Console.ReadLine();
        bread.Quantity = int.Parse(userBreadOrder);
        pastry.Quantity = int.Parse(userPastryOrder);
        ConfirmOrEditOrder(bread, pastry);
      }
    }

    static void GetOrderTotal(Bread bread, Pastry pastry)
    {
      int breadCost = bread.GetBreadCost();
      int pastryCost = pastry.GetPastryCost();
      int totalOrderCost = breadCost + pastryCost;
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("The cost of your order is: " + "$" + totalOrderCost);
      Console.WriteLine("------------------------------------------------------");
      Console.WriteLine("Would you like to place another order? Please enter 'new'.");
      Console.WriteLine("You can also enter 'done' or any other key to exit this app.");
      string userResponse = Console.ReadLine();
      if (userResponse == "new" || userResponse == "New")
      {
        Main();
      }
      else if (userResponse == "done" || userResponse == "Done")
      {
        Console.WriteLine("Thank you! Please come again!");
      }
      else
      {
        Console.WriteLine("Thank you! Please come again!");
      }
    }
  }
}