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
      Console.WriteLine(loafCost);
      Console.WriteLine(orderTotal);
      int numberOfLoaves = Loaves;
      Console.WriteLine(numberOfLoaves);
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