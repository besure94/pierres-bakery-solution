using System;

namespace PierresBakery.Models
{
  public class Bread
  {

    public int Loaves { get; set; }

    public Bread(int loaves)
    {
      Loaves = loaves;
    }

    public int GetBreadCost()
    {
      int loafCost = 5;
      int orderTotal = 0;
      int numberOfLoaves = Loaves;
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