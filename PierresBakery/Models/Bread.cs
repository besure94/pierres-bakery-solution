using System;

namespace PierresBakery.Models
{
  public class Bread
  {

    public int Quantity { get; set; }

    public Bread(int quantity)
    {
      Quantity = quantity;
    }

    public int GetBreadCost()
    {
      int loafCost = 5;
      int orderTotal = 0;
      int numberOfLoaves = Quantity;
      for (int i = 1; i <= numberOfLoaves; i++)
      {
        if (i % 3 == 0)
        {
          orderTotal += 0;
        }
        else
        {
          orderTotal += loafCost;
        }
      }
      return orderTotal;
    }

  }
}