using System;

namespace PierresBakery.Models
{
  public class Pastry
  {

    public int Quantity { get; set; }

    public Pastry(int quantity)
    {
      Quantity = quantity;
    }

    public int GetPastryCost()
    {
      int pastryCost = 2;
      int orderTotal = 0;
      int numberOfPastries = Quantity;
      for (int i = 1; i <= numberOfPastries; i++)
      {
        if (i % 4 == 0)
        {
          orderTotal += 0;
        }
        else
        {
          orderTotal += pastryCost;
        }
      }
      return orderTotal;
    }

  }
}