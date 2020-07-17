using System.Collections.Generic; 
using System; 

namespace TheBoulangerie.Models
{
  public class Bread
  {
    public int BreadAmount {get;}

    public Bread (int breadAmount)
      {
        BreadAmount = breadAmount;
      }
    public int CalculateBreadPrice(int breadAmount) 
      {
        if (BreadAmount% 3 == 0)
      {
        return (BreadAmount*5)-((BreadAmount/3)*5);
      }
      else if (BreadAmount% 3 == 1)
      {
        return ((BreadAmount*5)-(((BreadAmount-1)/3)*5));
      }
      else
      {
        return ((BreadAmount*5)-(((BreadAmount-2)/3)*5));
      }
    }
  }
}
  