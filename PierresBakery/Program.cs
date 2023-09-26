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
      Console.WriteLine("A loaf of bread costs $5, and every 3rd loaf is free! For example, two loaves of bread would cost $10.");
      Console.WriteLine("A pastry costs $2, and every 4th pastry is free! For example, two pastries would cost $4.");
      Console.WriteLine("Please enter how many loaves of bread you would like to order:");
      string breadLoaves = Console.ReadLine();
      Console.WriteLine("Please enter how many pastries you would like to order:");
      string pastries = Console.ReadLine();
      int breadQuantity = int.Parse(breadLoaves);
      int pastryQuantity = int.Parse(pastries);
      Bread bread = new Bread(breadQuantity);
      Pastry pastry = new Pastry(pastryQuantity);
      ConfirmOrEditOrder(bread, pastry);
    }

    static void ConfirmOrEditOrder(Bread bread, Pastry pastry)
    {
      Console.WriteLine("Please confirm that your order is correct:");
      Console.WriteLine($"Bread: {bread.Quantity}");
      Console.WriteLine($"Pastry: {pastry.Quantity}");
      Console.WriteLine("Is that correct? Enter 'yes' to continue, or 'no' to re-enter the amount.");
      string userInput = Console.ReadLine();
      if (userInput == "yes" || userInput == "Yes")
      {
        GetOrderTotal(bread, pastry);
      }
      else
      {
        Console.WriteLine("Please re-enter the amount of loaves and pastries that you would like to order:");
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
      Console.WriteLine("Would you like to place another order (new)?");
      Console.WriteLine("If not, you can enter 'done' to exit this app.");
      string userResponse = Console.ReadLine();
      if (userResponse == "new" || userResponse == "New")
      {
        Main();
      }
      else if (userResponse == "done" || userResponse == "Done")
      {
        Console.WriteLine("Thank you! Please come again!");
      }
    }
  }
}